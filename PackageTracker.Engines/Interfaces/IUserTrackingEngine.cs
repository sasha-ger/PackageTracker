namespace PackageTracker.Engines;

public interface IUserTrackingEngine
{
    string GetPackageStatus(int packageId);
    string GetPackageDetails(int packageId);
    string BuildStatusString(int packageId);
}
