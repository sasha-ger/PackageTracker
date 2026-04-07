namespace PackageTracker.Engines;

public class RequestEngine : IRequestEngine
{
    public void ProcessDeliveryRequest(int customerId, string origin, string destination, double weight)
    {
        throw new NotImplementedException();
    }

    public bool ValidateDeliveryLocations(string origin, string destination)
    {
        throw new NotImplementedException();
    }

    public void DispatchDrone(int depotId, int packageId)
    {
        throw new NotImplementedException();
    }
}
