using Microsoft.AspNetCore.Mvc;

namespace PackageTracker.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PackagesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(new[] { "Package 1", "Package 2" }); // placeholder
    }
}