using Microsoft.AspNetCore.Mvc;

namespace PackageTracker.Managers.Interfaces;

public interface IStaffManager
{
    // Returns all drones with their current status and depot location
    Task<IActionResult> GetAllDrones();

    // Returns the drone currently carrying a given package
    Task<IActionResult> GetDroneByPackage(int packageId);

    // Returns all packages that have not yet been delivered
    Task<IActionResult> GetAllActivePackages();
}
