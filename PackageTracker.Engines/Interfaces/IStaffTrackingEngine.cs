using PackageTracker.Models;

namespace PackageTracker.Engines;

public interface IStaffTrackingEngine
{
    Task<List<Drone>> GetAllDroneStatuses();
    Task<Package?> GetPackageAssignedToDrone(int droneId);
    Task<List<Package>> GetAllActivePackages();
    Task<List<Package>> GetAllPackages();
    Task<Drone?> GetDroneByPackage(int packageId);
    Task ManualDispatchDrone(int droneId, int fromDepotId, int toDepotId);
}
