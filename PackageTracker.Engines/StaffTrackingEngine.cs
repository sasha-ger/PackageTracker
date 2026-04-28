using PackageTracker.Accessors.Interfaces;
using PackageTracker.Models;
using PackageTracker.Models.Enums;

namespace PackageTracker.Engines;

public class StaffTrackingEngine(IDroneAccessor droneAccessor, IPackageAccessor packageAccessor, IDepotAccessor depotAccessor, IRoutingEngine routingEngine) : IStaffTrackingEngine
{
    public async Task<List<Drone>> GetAllDroneStatuses()
    {
        return await droneAccessor.GetAll();
    }

    public async Task<Package?> GetPackageAssignedToDrone(int droneId)
    {
        var drone = await droneAccessor.GetById(droneId)
            ?? throw new Exception($"Drone {droneId} not found.");

        if (drone.CurrentPackageId == null)
            return null;

        return await packageAccessor.GetById(drone.CurrentPackageId.Value);
    }

    public async Task<Drone?> GetDroneByPackage(int packageId)
    {
        return await droneAccessor.GetByCurrentPackageId(packageId);
    }

    public async Task<List<Package>> GetAllActivePackages()
    {
        return await packageAccessor.GetAllActive();
    }

    public async Task<List<Package>> GetAllPackages()
    {
        return await packageAccessor.GetAll();
    }

    public async Task ManualDispatchDrone(int droneId, int fromDepotId, int toDepotId)
    {
        var drone = await droneAccessor.GetById(droneId)
            ?? throw new ArgumentException($"Drone {droneId} not found.");

        if (drone.Status != DroneStatus.Idle)
            throw new ArgumentException($"Drone {droneId} is not idle.");

        if (drone.CurrentDepotId != fromDepotId)
            throw new ArgumentException($"Drone {droneId} is not at depot {fromDepotId}.");

        var fromDepot = await depotAccessor.GetById(fromDepotId)
            ?? throw new ArgumentException($"Depot {fromDepotId} not found.");
        var toDepot = await depotAccessor.GetById(toDepotId)
            ?? throw new ArgumentException($"Depot {toDepotId} not found.");

        var dist = routingEngine.GetDistance(
            fromDepot.Location.Latitude, fromDepot.Location.Longitude,
            toDepot.Location.Latitude, toDepot.Location.Longitude);

        drone.Status = DroneStatus.InTransit;
        drone.CurrentDepotId = null;
        drone.DestinationDepotId = toDepotId;
        drone.EstimatedArrivalTime = DateTime.UtcNow + routingEngine.GetTravelTime(dist);
        await droneAccessor.UpdateDrone(drone);
    }
}
