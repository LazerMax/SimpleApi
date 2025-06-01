using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Service is running");
}