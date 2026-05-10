using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinguaListen.API.Controllers;

[Route("api/lookup")]
[Authorize]
public class LookupController(ISender sender) : BaseApiController(sender)
{

    [HttpGet]
    public async Task<IActionResult> Lookup([FromQuery] string term, [FromQuery] string language, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
