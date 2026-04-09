using Microsoft.AspNetCore.Mvc;
using PackageTracker.Engines;
using PackageTracker.Managers.Interfaces;

namespace PackageTracker.Managers.Controllers;

[ApiController]
[Route("api/staff")]
public class StaffController(IStaffTrackingEngine staffTrackingEngine)
    : ControllerBase, IStaffManager
{
    // GET api/staff/drones
    [HttpGet("drones")]
    public Task<IActionResult> GetAllDrones()
    {
        throw new NotImplementedException();
    }

    // GET api/staff/drones/by-package/{packageId}
    [HttpGet("drones/by-package/{packageId}")]
    public Task<IActionResult> GetDroneByPackage(int packageId)
    {
        throw new NotImplementedException();
    }

    // GET api/staff/packages/active
    [HttpGet("packages/active")]
    public Task<IActionResult> GetAllActivePackages()
    {
        throw new NotImplementedException();
    }
}
