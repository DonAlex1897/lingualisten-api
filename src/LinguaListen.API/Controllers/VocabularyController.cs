using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinguaListen.API.Controllers;

[Route("api/vocabulary")]
[Authorize]
public class VocabularyController(ISender sender) : BaseApiController(sender)
{

    [HttpGet]
    public async Task<IActionResult> GetVocabulary(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> SaveWord(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateWord(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteWord(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
