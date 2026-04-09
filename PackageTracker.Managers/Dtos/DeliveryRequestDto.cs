namespace PackageTracker.Managers.Dtos;

public class DeliveryRequestDto
{
    public int CustomerId { get; set; }
    public string OriginAddress { get; set; } = null!;
    public string DestinationAddress { get; set; } = null!;
    public double Weight { get; set; }
    public string Recipient { get; set; } = null!;
}
