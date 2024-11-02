using Microsoft.AspNetCore.Mvc;
using TaskChallenge.Application.UseCases.Task.Register;
using TaskChallenge.Application.UseCases.Task.Update;
using TaskChallenge.Communication.Requests;
using TaskChallenge.Communication.Responses;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TarefaChallenge.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult RegisterTask([FromBody] RequestRegisterTaskJson request)
    {
        var response = new RegisterTaskUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{Id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] Guid Id, [FromBody] RequestRegisterTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();

        var errors = new ResponseErrorJson();

        try
        {
            useCase.Execute(Id, request);

            return NoContent();
        }
        catch (ArgumentException ex)
        {
            errors.Errors.Add(ex.Message);
            return BadRequest(errors);
        }
    }

}
