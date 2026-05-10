using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinguaListen.API.Controllers;

[Route("api/srs")]
[Authorize]
public class SrsController(ISender sender) : BaseApiController(sender)
{

    [HttpGet("due")]
    public async Task<IActionResult> GetDueCards(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost("review")]
    public async Task<IActionResult> SubmitReview(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpGet("stats")]
    public async Task<IActionResult> GetStats(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
