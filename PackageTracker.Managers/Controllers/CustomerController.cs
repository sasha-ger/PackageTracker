using Microsoft.AspNetCore.Mvc;
using PackageTracker.Engines;
using PackageTracker.Managers.Dtos;
using PackageTracker.Managers.Interfaces;

namespace PackageTracker.Managers.Controllers;

[ApiController]
[Route("api/customer")]
public class CustomerController(IRequestEngine requestEngine, IUserTrackingEngine userTrackingEngine)
    : ControllerBase, ICustomerManager
{
    // POST api/customer/request
    [HttpPost("request")]
    public Task<IActionResult> CreateDeliveryRequest(DeliveryRequestDto request)
    {
        throw new NotImplementedException();
    }

    // GET api/customer/package/{packageId}/status
    [HttpGet("package/{packageId}/status")]
    public Task<IActionResult> GetPackageStatus(int packageId)
    {
        throw new NotImplementedException();
    }

    // GET api/customer/{userId}/packages
    [HttpGet("{userId}/packages")]
    public Task<IActionResult> GetPackagesByCustomer(int userId)
    {
        throw new NotImplementedException();
    }
}
