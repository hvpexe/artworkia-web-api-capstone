using Application.Commons;
using Application.Models;
using Application.Models.ZaloPayModels;
using Application.Services.Abstractions;
using Domain.Entitites;
using Domain.Enums;
using Domain.Repositories.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nest;
using Serilog;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentsController : ControllerBase
{
    private readonly IZaloPayService _zaloPayService;
    private readonly IWalletHistoryService _walletHistoryService;
    private readonly IWalletService _walletService;
    private readonly IClaimService _claimService;
    private readonly IUnitOfWork _unitOfWork;

    public PaymentsController(IZaloPayService zaloPayService,
        IWalletHistoryService walletHistoryService,
        IWalletService walletService,
        IClaimService claimService,
        IUnitOfWork unitOfWork)
    {
        _zaloPayService = zaloPayService;
        _walletHistoryService = walletHistoryService;
        _walletService = walletService;
        _claimService = claimService;
        _unitOfWork = unitOfWork;
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> CreatePaymentOrder(OrderCreateModel model)
    {
        try
        {
            // create (post) zalopay order
            var zaloPayOrderCreate = _zaloPayService.BuildZaloPayOrderCreate(model);
            var result = await _zaloPayService.CreateOrderAsync(zaloPayOrderCreate);
            if (result == null || result.ReturnCode != 1)
            {
                return BadRequest(result);
            }

            // create order successfully -> save history to DB            
            var currentUserId = _claimService.GetCurrentUserId ?? default;
            var wallet = await _walletService.GetWalletByAccountIdAsync(currentUserId);
            if (wallet == null)
            {
                return BadRequest("Người dùng này chưa kích hoạt ví.");
            }
            var walletHistory = new WalletHistory
            {
                Amount = zaloPayOrderCreate.Amount, // amount in history is VND
                AppTransId = zaloPayOrderCreate.AppTransId,
                Type = Domain.Enums.WalletHistoryTypeEnum.Deposit,
                WalletBalance = wallet.Balance
            };
            await _walletHistoryService.AddWalletHistory(walletHistory);
            // return result
            result.AppTransId = zaloPayOrderCreate.AppTransId;
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPost("callback")]
    public async Task<IActionResult> Callback([FromBody] ZPCallbackOrderResponse callbackOrder)
    {
        var result = new Dictionary<string, object>();
        try
        {
            // check valid callback (from ZaloPay server)
            if (!_zaloPayService.ValidateCallback(callbackOrder))
            {
                // invalid callback
                result["return_code"] = -1;
                result["return_message"] = "mac not equal";
                //Log.Error("*****Mac not equal*****");
            }
            else
            {   // payment success
                // update order status
                var callbackData = callbackOrder.ToCallbackOrderData();
                if (callbackData == null)
                {
                    throw new ArgumentException("Callback Data is invalid json format.");
                }                
                
                var walletHistory = await _unitOfWork.WalletHistoryRepository
                            .GetSingleByConditionAsync(x => x.AppTransId.Equals(callbackData.AppTransId));
                if (walletHistory == null)
                {
                    return BadRequest(new { ErrorMessage = "Không tìm thấy giao dịch của ví." });
                }
                var wallet = await _walletService.GetWalletByAccountIdAsync(walletHistory.CreatedBy!.Value);
                if (wallet == null)
                {
                    return BadRequest("Người dùng này chưa kích hoạt ví.");
                }
                var walletBalance = wallet.Balance + callbackData.Amount;
                // update status
                walletHistory.TransactionStatus = TransactionStatusEnum.Success;
                walletHistory.WalletBalance = walletBalance;
                _unitOfWork.WalletHistoryRepository.Update(walletHistory);                
                // update coins in db
                var accountId = Guid.Parse(callbackData.AppUser);
                var coins = callbackData.Amount;
                await _walletService.AddCoinsToWallet(accountId, coins, false);
                await _unitOfWork.SaveChangesAsync();
                // return result
                result["return_code"] = 1;
                result["return_message"] = "success";
            }
        }
        catch (Exception ex)
        {
            result["return_code"] = 0; // ZaloPay server will callback again (up to 3 times)
            result["return_message"] = ex.Message;
            Log.Error($"*****{ex.Message}*****");
        }
        return Ok(result);
    }

    [HttpGet("query-order/{appTransId}")]
    [Authorize]
    public async Task<IActionResult> QueryOrder(string appTransId)
    {
        try
        {
            // query zalo pay order status
            var result = await _zaloPayService.QueryOrderAsync(appTransId);
            // return result
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet("query-order/{appTransId}/ws")]
    [Authorize]
    public async Task QueryOrderWebSocket(string appTransId)
    {
        try
        {
            if (HttpContext.WebSockets.IsWebSocketRequest)
            {
                using (var ws = await HttpContext.WebSockets.AcceptWebSocketAsync())
                {
                    var result = await _zaloPayService.QueryOrderAsync(appTransId);
                    while (ws.State == WebSocketState.Open)
                    {
                        var jsonString = JsonSerializer.Serialize(result);
                        var buffer = Encoding.UTF8.GetBytes(jsonString);
                        await ws.SendAsync(
                            new ArraySegment<byte>(buffer),
                            WebSocketMessageType.Text,
                            true,
                            CancellationToken.None);
                        if (!result!.IsProcessing)
                        {
                            break;
                        }
                    }
                    // close ws connection
                    await ws.CloseAsync(WebSocketCloseStatus.NormalClosure,
                        "WebSocket connection closed by Server.", CancellationToken.None);
                }
            }
            else
            {
                HttpContext.Response.StatusCode = StatusCodes.Status406NotAcceptable;
                await HttpContext.Response.WriteAsync("Only support WebSocket protocol!");
            }
        }
        catch (Exception ex)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await HttpContext.Response.WriteAsync(ex.Message);
        }
    }

    // for testing the callback api
    [HttpPost("hmac")]
    public IActionResult GetHMacString(EncodeBodyModel model)
    {
        var hMacString = CryptoHelper.HMacCompute(model.Key, model.EncodeData);
        return Ok(hMacString);
    }

    [HttpPost("query-account")]
    [Authorize]
    public async Task<IActionResult> QueryPaymentAccount([FromBody] UserQueryModel model)
    {
        try
        {
            var result = await _zaloPayService.QueryZalopayUserAsync(model);
            if (result == null || result.ReturnCode != 1)
            {
                return BadRequest(result);
            }
            // verify successfully -> save new wallet info to DB
            await _walletService.UpdateCurrentWalletAsync(new WalletEM { WithdrawInformation = model.Phone });

            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPost("topup")]
    [Authorize]
    public async Task<IActionResult> ZalopayTopup([FromBody] TopupModel model)
    {
        try
        {
            // check if the coins balance in wallet is enough
            var currentUserId = _claimService.GetCurrentUserId ?? default;
            if (!await _walletService.CheckWithdrawBalance(currentUserId, model.Amount))
            {
                return BadRequest("Not enough coins! The remaining balance in your wallet is not enough to make this transaction.");
            }
            var wallet = await _walletService.GetWalletByAccountIdAsync(currentUserId);
            if (wallet == null)
            {
                return BadRequest("Người dùng này chưa kích hoạt ví.");
            }
            // create new transaction & save in db
            var transaction = new WalletHistory
            {
                Amount = - model.Amount,
                Type = WalletHistoryTypeEnum.Withdraw,
                WalletBalance = wallet.Balance,
            };
            await _walletHistoryService.AddWalletHistory(transaction);

            var result = await _zaloPayService.ZalopayTopupAsync(model, transaction.Id);
            if (result == null || result.ReturnCode != 1)
            {
                //update transaction status & refunds coins
                await _walletHistoryService.UpdateWalletHistoryStatus(
                                                    transaction.Id, TransactionStatusEnum.Failed);
                return BadRequest(result);
            }
            // verify successfully -> update transaction status
            transaction.TransactionStatus = TransactionStatusEnum.Success;
            transaction.AppTransId = result.Data!.OrderId;
            transaction.WalletBalance -= model.Amount;
            await _walletHistoryService.UpdateWalletHistory(transaction.Id, transaction);
            // update coins balance            
            await _walletService.AddCoinsToWallet(currentUserId, - model.Amount);
            return Ok(result);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            return StatusCode(400, ex.Message);
        }
        catch (ArgumentException ex)
        {
            return StatusCode(400, ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet("merchant-balance")]
    [Authorize]
    //remember authorize for admin/moderator
    public async Task<IActionResult> QueryMerchantBalance()
    {
        try
        {
            var result = await _zaloPayService.QueryMerchantBalanceAsync();
            if (result == null || result.ReturnCode != 1)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}

// for testing the callback api
public class EncodeBodyModel
{
    public string Key { get; set; } = default!;
    public string EncodeData { get; set; } = default!;
}
