using Microsoft.AspNetCore.Mvc;

namespace asp_todo.Controllers;

[ApiController]
[Route("/api/todos")]
public class TodoController
{
    private readonly ILogger<TodoController> _ctx;

    public TodoController()
    {
    }

    [HttpGet]
    public Response Get()
}