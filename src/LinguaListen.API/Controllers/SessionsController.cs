using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinguaListen.API.Controllers;

[Route("api/sessions")]
[Authorize]
public class SessionsController(ISender sender) : BaseApiController(sender)
{

    [HttpGet]
    public async Task<IActionResult> GetSessions(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetSession(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> CreateSession(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteSession(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
