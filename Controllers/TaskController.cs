using Microsoft.AspNetCore.Mvc;

namespace Amtlis.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { status = "API is running" });
    }
}
