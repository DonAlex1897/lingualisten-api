using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinguaListen.API.Controllers;

[Route("api/auth")]
public class AuthController(ISender sender) : BaseApiController(sender)
{

    [HttpPost("register")]
    [AllowAnonymous]
    public async Task<IActionResult> Register(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost("refresh")]
    [AllowAnonymous]
    public async Task<IActionResult> Refresh(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost("logout")]
    [Authorize]
    public async Task<IActionResult> Logout(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost("confirm-email")]
    [AllowAnonymous]
    public async Task<IActionResult> ConfirmEmail(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpGet("resend-confirmation")]
    [Authorize]
    public async Task<IActionResult> ResendConfirmation(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost("forgot-password")]
    [AllowAnonymous]
    public async Task<IActionResult> ForgotPassword(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost("reset-password")]
    [AllowAnonymous]
    public async Task<IActionResult> ResetPassword(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost("google")]
    [AllowAnonymous]
    public async Task<IActionResult> Google(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
