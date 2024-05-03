using Application.Models;
using Application.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Utils;

namespace WebApi.Controllers;

[ApiController]
public class TransactionHistoriesController : ControllerBase
{
    private readonly ITransactionHistoryService _transactionHistoryService;
    private readonly IWalletHistoryService _walletHistoryService;

    public TransactionHistoriesController(
        ITransactionHistoryService transactionHistoryService,
        IWalletHistoryService walletHistoryService)
    {
        _transactionHistoryService = transactionHistoryService;
        _walletHistoryService = walletHistoryService;
    }

    //GET: api/account/{accountId}/transaction-histories
    [Route("api/account/{accountId}/transaction-histories")]
    [HttpGet]
    [Authorize]
    public async Task<ActionResult> GetTransactionHistoriesByAccount(Guid accountId)
    {
        try
        {
            var transactionHistories = await _transactionHistoryService
                .GetTransactionHistoriesOfAccount(accountId);
            return Ok(transactionHistories);
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new ApiResponse { ErrorMessage = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ApiResponse { ErrorMessage = ex.Message });
        }
    }

    //GET: api/account/{accountId}/transaction-histories
    [Route("api/account/{accountId}/general-histories")]
    [HttpGet]
    [Authorize]
    public async Task<ActionResult> GetGeneralHistoryByAccount(Guid accountId)
    {
        try
        {
            var generalHistories = new List<TransactionGeneralVM>();
            // add transaction histories to general list
            var transactionHistories = await _transactionHistoryService
                .GetTransactionHistoriesOfAccount(accountId);
            foreach(var history in  transactionHistories)
            {
                generalHistories.Add(new TransactionGeneralVM
                {
                    TransactionHistory = history,
                    CreatedOn = history.CreatedOn
                });
            }
            // add wallet histories to general list
            var walletHistories = await _walletHistoryService
                .GetWalletHistoriesOfAccount(accountId);            
            foreach (var history in walletHistories)
            {
                generalHistories.Add(new TransactionGeneralVM
                {
                    WalletHistory = history,
                    CreatedOn = history.CreatedOn
                });
            }

            generalHistories = generalHistories.OrderByDescending(x => x.CreatedOn).ToList();

            return Ok(generalHistories);
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new ApiResponse { ErrorMessage = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ApiResponse { ErrorMessage = ex.Message });
        }
    }
}
