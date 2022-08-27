using Application.ToDos;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class ToDoListController : BaseApiController
{

    [HttpGet]
    public async Task<ActionResult<List<TodoList>>> Get()
    {
        var result = await Mediator.Send(new GetTodos.Query());

        return result.Payload;
    }
}
