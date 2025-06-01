using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;

namespace SimpleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController : ControllerBase
{
    private static readonly List<Author> Authors = new()
    {
        new Author { Id = 1, Name = "John Smith" },
        new Author { Id = 2, Name = "Alice Johnson" }
    };

    [HttpGet]
    public IActionResult Get() => Ok(Authors);

    [HttpGet("{id}")]
    public IActionResult Get(int id) => Ok(Authors.FirstOrDefault(a => a.Id == id));
}