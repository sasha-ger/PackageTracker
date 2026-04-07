namespace PackageTracker.Engines;

public class RoutingEngine : IRoutingEngine
{
    public double GetDistance(double lat1, double lng1, double lat2, double lng2)
    {
        throw new NotImplementedException();
    }

    public bool IsWithinRange(double lat, double lng)
    {
        throw new NotImplementedException();
    }

    public int FindNearestDepot(double lat, double lng)
    {
        throw new NotImplementedException();
    }

    public List<int> FindShortestRoute(int originDepotId, int destinationDepotId)
    {
        throw new NotImplementedException();
    }
}