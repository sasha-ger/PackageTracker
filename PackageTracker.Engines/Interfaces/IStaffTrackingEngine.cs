namespace PackageTracker.Engines;

public interface IStaffTrackingEngine
{
    // Returns all drones with status and depot info
    // TODO: return type will change to List<Drone> once Models are defined
    object GetAllDroneStatuses();
    
    object GetPackageAssignedToDrone(int droneId);
    
    object GetAllActivePackages();
}
