using Application.Models;
using Application.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Utils;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProposalAssetsController : ControllerBase
{
    private readonly IProposalAssetService _proposalAssetService;

    public ProposalAssetsController(IProposalAssetService proposalAssetService)
    {
        _proposalAssetService = proposalAssetService;
    }

    [HttpGet("{proposalId}")]
    [Authorize]
    public async Task<IActionResult> GetProposalAssetsOfProposal(Guid proposalId)
    {
        try
        {
            var result = await _proposalAssetService.GetProposalAssetsOfProposalAsync(proposalId);
            return Ok(result);
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

    [HttpGet("download/{proposalId}")]
    [Authorize]
    public async Task<IActionResult> GetProposalAssetDownloadById(Guid proposalId)
    {
        try
        {
            var link = await _proposalAssetService.GetDownloadUriProposalAssetAsync(proposalId);
            return Ok(new { link });
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new ApiResponse { ErrorMessage = ex.Message });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new ApiResponse { ErrorMessage = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ApiResponse { ErrorMessage = ex.Message });
        }
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> CreateProposalAssets([FromForm] ProposalAssetModel model)
    {
        try
        {
            var result = await _proposalAssetService.AddProposalAssetAsync(model);
            return Ok(result);
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
