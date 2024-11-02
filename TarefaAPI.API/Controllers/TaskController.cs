using Microsoft.AspNetCore.Mvc;
using TaskChallenge.Application.UseCases.Task.Register;
using TaskChallenge.Communication.Requests;

namespace TarefaChallenge.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    public IActionResult RegisterTask([FromBody] RequestRegisterTaskJson request)
    {
        var response = new RegisterTaskUseCase().Execute(request);

        return Created(string.Empty, response);
    }
}
