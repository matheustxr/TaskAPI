using Microsoft.AspNetCore.Mvc;
using TaskChallenge.Application.UseCases.Task.Delete;
using TaskChallenge.Application.UseCases.Task.GetAll;
using TaskChallenge.Application.UseCases.Task.GetById;
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
    public IActionResult Register([FromBody] RequestRegisterTaskJson request)
    {
        var response = new RegisterTaskUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{Id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] Guid Id, [FromBody] RequestRegisterTaskJson request)
    {
        try
        {
            var useCase = new UpdateTaskUseCase();

            useCase.Execute(Id, request);

            return NoContent();
        }
        catch (ArgumentException ex)
        {
            var responseError = new ResponseErrorJson
            {
                Errors = new List<string> { ex.Message }
            };
            return NotFound(responseError);
        }
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseGetAllTasksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTasksUseCase();

        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{Id}")]
    [ProducesResponseType(typeof(ResponseGetByIdTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] Guid Id)
    {
        try
        {
            var useCase = new GetByIdUseCase();

            var response = useCase.Execute(Id);

            return Ok(response);
        }
        catch (ArgumentException ex)
        {
            var responseError = new ResponseErrorJson
            {
                Errors = new List<string> { ex.Message }
            };
            return NotFound(responseError);
        }
    }

    [HttpDelete]
    [Route("{Id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] Guid Id)
    {
        try
        {
            var useCase = new DeleteTaskUseCase();

            useCase.Execute(Id);

            return NoContent();
        }
        catch (ArgumentException ex)
        {
            var responseError = new ResponseErrorJson
            {
                Errors = new List<string> { ex.Message }
            };
            return NotFound(responseError);
        }
    }

}
