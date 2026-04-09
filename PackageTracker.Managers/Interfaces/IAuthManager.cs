using Microsoft.AspNetCore.Mvc;

namespace PackageTracker.Managers.Interfaces;

public interface IAuthManager
{
    // Validates credentials and returns a JWT token on success
    Task<IActionResult> Login(string email, string password);

    // Invalidates the given JWT token and ends the session
    Task<IActionResult> Logout(string token);

    // Returns the role (customer or staff) encoded in the token
    IActionResult GetUserRole(string token);

    // Checks that the token is valid and not expired
    IActionResult ValidateToken(string token);
}
