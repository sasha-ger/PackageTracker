using Microsoft.AspNetCore.Mvc;
using PackageTracker.Managers.Dtos;

namespace PackageTracker.Managers.Interfaces;

public interface ICustomerManager
{
    // Accepts a delivery request and routes it to the RequestEngine for processing
    Task<IActionResult> CreateDeliveryRequest(DeliveryRequestDto request);

    // Returns the current status and last known depot location for a package
    Task<IActionResult> GetPackageStatus(int packageId);

    // Returns all packages associated with a given customer ID
    Task<IActionResult> GetPackagesByCustomer(int userId);
}
