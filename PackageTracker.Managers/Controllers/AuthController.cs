using Microsoft.AspNetCore.Mvc;
using PackageTracker.Managers.Interfaces;

namespace PackageTracker.Managers.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase, IAuthManager
{
    // POST api/auth/login
    [HttpPost("login")]
    public Task<IActionResult> Login(string email, string password)
    {
        throw new NotImplementedException();
    }

    // POST api/auth/logout
    [HttpPost("logout")]
    public Task<IActionResult> Logout(string token)
    {
        throw new NotImplementedException();
    }

    // GET api/auth/role
    [HttpGet("role")]
    public IActionResult GetUserRole(string token)
    {
        throw new NotImplementedException();
    }

    // GET api/auth/validate
    [HttpGet("validate")]
    public IActionResult ValidateToken(string token)
    {
        throw new NotImplementedException();
    }
}
