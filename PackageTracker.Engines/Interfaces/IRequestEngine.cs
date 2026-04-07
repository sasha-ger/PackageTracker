namespace PackageTracker.Engines;

public interface IRequestEngine
{
    void ProcessDeliveryRequest(int customerId, string origin, string destination, double weight);
    bool ValidateDeliveryLocations(string origin, string destination);
    void DispatchDrone(int depotId, int packageId);
}
