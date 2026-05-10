using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LinguaListen.API.Controllers;

[ApiController]
public abstract class BaseApiController(ISender sender) : ControllerBase
{
    protected readonly ISender Sender = sender;
}
