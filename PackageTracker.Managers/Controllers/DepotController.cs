using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PackageTracker.Accessors.Interfaces;
using PackageTracker.Managers.Dtos;

namespace PackageTracker.Managers.Controllers;

[Authorize]
[ApiController]
[Route("api/depots")]
public class DepotController(IDepotAccessor depotAccessor) : ControllerBase
{
    // GET api/depots
    // Returns all depots in the network.
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var depots = await depotAccessor.GetAll();
        var dtos = depots.Select(d => new DepotDto
        {
            DepotId = d.Id,
            Name = d.Name,
            Latitude = d.Location.Latitude,
            Longitude = d.Location.Longitude,
            Address = d.Location.Address
        });
        return Ok(dtos);
    }
}
