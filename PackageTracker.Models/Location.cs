using System;

namespace PackageTracker.Models;
public class Location
{
	public int Id { get; set; }
	public string? Address { get; set; }
	public double Longitude { get; set; }
	public double Latitude { get; set; } 
}

