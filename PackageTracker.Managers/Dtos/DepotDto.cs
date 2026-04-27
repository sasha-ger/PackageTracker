namespace PackageTracker.Managers.Dtos;

public class DepotDto
{
    public int DepotId { get; set; }
    public string Name { get; set; } = null!;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string? Address { get; set; }
}
