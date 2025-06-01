using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;

namespace SimpleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private static readonly List<Book> Books = new()
    {
        new Book { Id = 1, Title = ".NET Core Programming", AuthorId = 1 },
        new Book { Id = 2, Title = "API Design Patterns", AuthorId = 2 }
    };

    [HttpGet]
    public IActionResult Get() => Ok(Books);

    [HttpGet("{id}")]
    public IActionResult Get(int id) => Ok(Books.FirstOrDefault(b => b.Id == id));
}