using Microsoft.EntityFrameworkCore;
using PackageTracker.Models;
using PackageTracker.Models.Enums;

namespace PackageTracker.Accessors.Data;
public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
	public DbSet<Depot> Depots { get; set; }
	public DbSet<Drone> Drones { get; set; }
	public DbSet<Location> Locations { get; set; }
	public DbSet<Package> Packages { get; set; }
	public DbSet<User> Users { get; set; }
	public DbSet<PackageStatusEvent> PackageStatusEvents { get; set; }


	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Drone has two FKs to Depot — must be explicit so EF doesn't get confused
		modelBuilder.Entity<Drone>()
			.HasOne(d => d.HomeDepot)
			.WithMany()
			.HasForeignKey(d => d.HomeDepotId)
			.OnDelete(DeleteBehavior.Restrict);

		// Package has two FKs to Location — same issue
		modelBuilder.Entity<Package>()
			.HasOne(p => p.OriginLocation)
			.WithMany()
			.HasForeignKey(p => p.OriginLocationId)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<Package>()
			.HasOne(p => p.DestinationLocation)
			.WithMany()
			.HasForeignKey(p => p.DestinationLocationId)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<Package>()
			.HasOne(p => p.Sender)
			.WithMany()
			.HasForeignKey(p => p.SenderId)
			.OnDelete(DeleteBehavior.Restrict);

		// Drone's CurrentDepot can be null (if drone is in transit)
		modelBuilder.Entity<Drone>()
			.HasOne(d => d.CurrentDepot)
			.WithMany()
			.HasForeignKey(d => d.CurrentDepotId)
			.IsRequired(false)
			.OnDelete(DeleteBehavior.Restrict);
		
		modelBuilder.Entity<Drone>()
			.HasOne(d => d.CurrentPackage)
			.WithMany()
			.HasForeignKey(d => d.CurrentPackageId)
			.IsRequired(false)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<Drone>()
			.HasOne(d => d.DestinationDepot)
			.WithMany()
			.HasForeignKey(d => d.DestinationDepotId)
			.IsRequired(false)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<PackageStatusEvent>()
			.HasOne(e => e.Package)
			.WithMany()
			.HasForeignKey(e => e.PackageId)
			.OnDelete(DeleteBehavior.Cascade);

		modelBuilder.Entity<PackageStatusEvent>()
			.HasOne(e => e.Depot)
			.WithMany()
			.HasForeignKey(e => e.DepotId)
			.IsRequired(false)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<Depot>().HasData(
		 new Depot { Id = 1, Name = "Seward Depot", LocationId = 1 },
		 new Depot { Id = 2, Name = "Pawnee Lake Depot", LocationId = 2 },
		 new Depot { Id = 3, Name = "Lincoln Northwest Depot", LocationId = 3 },
		 new Depot { Id = 4, Name = "Waverly Depot", LocationId = 4 },
		 new Depot { Id = 5, Name = "Greenwood Depot", LocationId = 5 },
		 new Depot { Id = 6, Name = "Melia Depot", LocationId = 6 },
		 new Depot { Id = 7, Name = "Millard Depot", LocationId = 7 },
		 new Depot { Id = 8, Name = "Omaha Depot", LocationId = 8 },
		 new Depot { Id = 9, Name = "Depot at 27th and O St", LocationId = 9 },
		 new Depot { Id = 10, Name = "Depot at 84th and O St", LocationId = 10 },
		 new Depot { Id = 11, Name = "Depot at 84th St and Hwy 2", LocationId = 11 }
		);
		
		modelBuilder.Entity<Drone>().HasData(
			// Depot 1
			new Drone { Id = 1,  HomeDepotId = 1,  CurrentDepotId = 1,  Status = DroneStatus.Idle },
			new Drone { Id = 2,  HomeDepotId = 1,  CurrentDepotId = 1,  Status = DroneStatus.Idle },
			new Drone { Id = 3,  HomeDepotId = 1,  CurrentDepotId = 1,  Status = DroneStatus.Idle },
			// Depot 2
			new Drone { Id = 4,  HomeDepotId = 2,  CurrentDepotId = 2,  Status = DroneStatus.Idle },
			new Drone { Id = 5,  HomeDepotId = 2,  CurrentDepotId = 2,  Status = DroneStatus.Idle },
			new Drone { Id = 6,  HomeDepotId = 2,  CurrentDepotId = 2,  Status = DroneStatus.Idle },
			// Depot 3
			new Drone { Id = 7,  HomeDepotId = 3,  CurrentDepotId = 3,  Status = DroneStatus.Idle },
			new Drone { Id = 8,  HomeDepotId = 3,  CurrentDepotId = 3,  Status = DroneStatus.Idle },
			new Drone { Id = 9,  HomeDepotId = 3,  CurrentDepotId = 3,  Status = DroneStatus.Idle },
			// Depot 4
			new Drone { Id = 10, HomeDepotId = 4,  CurrentDepotId = 4,  Status = DroneStatus.Idle },
			new Drone { Id = 11, HomeDepotId = 4,  CurrentDepotId = 4,  Status = DroneStatus.Idle },
			new Drone { Id = 12, HomeDepotId = 4,  CurrentDepotId = 4,  Status = DroneStatus.Idle },
			// Depot 5
			new Drone { Id = 13, HomeDepotId = 5,  CurrentDepotId = 5,  Status = DroneStatus.Idle },
			new Drone { Id = 14, HomeDepotId = 5,  CurrentDepotId = 5,  Status = DroneStatus.Idle },
			new Drone { Id = 15, HomeDepotId = 5,  CurrentDepotId = 5,  Status = DroneStatus.Idle },
			// Depot 6
			new Drone { Id = 16, HomeDepotId = 6,  CurrentDepotId = 6,  Status = DroneStatus.Idle },
			new Drone { Id = 17, HomeDepotId = 6,  CurrentDepotId = 6,  Status = DroneStatus.Idle },
			new Drone { Id = 18, HomeDepotId = 6,  CurrentDepotId = 6,  Status = DroneStatus.Idle },
			// Depot 7
			new Drone { Id = 19, HomeDepotId = 7,  CurrentDepotId = 7,  Status = DroneStatus.Idle },
			new Drone { Id = 20, HomeDepotId = 7,  CurrentDepotId = 7,  Status = DroneStatus.Idle },
			new Drone { Id = 21, HomeDepotId = 7,  CurrentDepotId = 7,  Status = DroneStatus.Idle },
			// Depot 8
			new Drone { Id = 22, HomeDepotId = 8,  CurrentDepotId = 8,  Status = DroneStatus.Idle },
			new Drone { Id = 23, HomeDepotId = 8,  CurrentDepotId = 8,  Status = DroneStatus.Idle },
			new Drone { Id = 24, HomeDepotId = 8,  CurrentDepotId = 8,  Status = DroneStatus.Idle },
			// Depot 9
			new Drone { Id = 25, HomeDepotId = 9,  CurrentDepotId = 9,  Status = DroneStatus.Idle },
			new Drone { Id = 26, HomeDepotId = 9,  CurrentDepotId = 9,  Status = DroneStatus.Idle },
			new Drone { Id = 27, HomeDepotId = 9,  CurrentDepotId = 9,  Status = DroneStatus.Idle },
			// Depot 10
			new Drone { Id = 28, HomeDepotId = 10, CurrentDepotId = 10, Status = DroneStatus.Idle },
			new Drone { Id = 29, HomeDepotId = 10, CurrentDepotId = 10, Status = DroneStatus.Idle },
			new Drone { Id = 30, HomeDepotId = 10, CurrentDepotId = 10, Status = DroneStatus.Idle },
			// Depot 11
			new Drone { Id = 31, HomeDepotId = 11, CurrentDepotId = 11, Status = DroneStatus.Idle },
			new Drone { Id = 32, HomeDepotId = 11, CurrentDepotId = 11, Status = DroneStatus.Idle },
			new Drone { Id = 33, HomeDepotId = 11, CurrentDepotId = 11, Status = DroneStatus.Idle }
		);

		modelBuilder.Entity<Location>().HasData(
		 // Depot locations (1–11)
		 new Location { Id = 1,  Longitude = -97.09659, Latitude = 40.82494 },
		 new Location { Id = 2,  Longitude = -96.89950, Latitude = 40.82654 },
		 new Location { Id = 3,  Longitude = -96.72906, Latitude = 40.86059 },
		 new Location { Id = 4,  Longitude = -96.55367, Latitude = 40.90044 },
		 new Location { Id = 5,  Longitude = -96.40375, Latitude = 40.96567 },
		 new Location { Id = 6,  Longitude = -96.27599, Latitude = 41.08659 },
		 new Location { Id = 7,  Longitude = -96.12001, Latitude = 41.18178 },
		 new Location { Id = 8,  Longitude = -95.94750, Latitude = 41.22241 },
		 new Location { Id = 9,  Longitude = -96.68186, Latitude = 40.81328 },
		 new Location { Id = 10, Longitude = -96.60705, Latitude = 40.81299 },
		 new Location { Id = 11, Longitude = -96.60448, Latitude = 40.73600 },
		 // Demo package locations (12–17)
		 new Location { Id = 12, Address = "123 Main St, Seward, NE",       Latitude = 40.9036, Longitude = -97.0973 },
		 new Location { Id = 13, Address = "456 Oak Ave, Lincoln, NE",       Latitude = 40.8136, Longitude = -96.7026 },
		 new Location { Id = 14, Address = "789 Pine Rd, Omaha, NE",         Latitude = 41.2524, Longitude = -95.9980 },
		 new Location { Id = 15, Address = "321 Elm St, Waverly, NE",        Latitude = 40.9131, Longitude = -96.5312 },
		 new Location { Id = 16, Address = "654 Maple Dr, Millard, NE",      Latitude = 41.1900, Longitude = -96.1200 },
		 new Location { Id = 17, Address = "987 Cedar Blvd, Greenwood, NE",  Latitude = 40.9749, Longitude = -96.4337 }
		);

		modelBuilder.Entity<User>().HasData(
		 new User { Id = 1, Username = "janedoe",   Firstname = "Jane", Lastname = "Doe",   Email = "jane@test.com",   Password = "password123", Role = UserRole.Customer },
		 new User { Id = 2, Username = "johnstaff", Firstname = "John", Lastname = "Smith", Email = "staff@test.com",  Password = "password123", Role = UserRole.Staff    },
		 new User { Id = 3, Username = "bobcustomer", Firstname = "Bob", Lastname = "Jones", Email = "bob@test.com",   Password = "password123", Role = UserRole.Customer }
		);

		modelBuilder.Entity<Package>().HasData(
		 new Package
		 {
		     Id = 1, TrackingNumber = "ABC12345", SenderId = 1, Recipient = "Bob Johnson",
		     OriginLocationId = 12, DestinationLocationId = 14,
		     Status = PackageStatus.Delivered,
		     CreatedAt = new DateTime(2026, 4, 25, 10, 0, 0, DateTimeKind.Utc),
		     UpdatedAt = new DateTime(2026, 4, 25, 12, 0, 0, DateTimeKind.Utc)
		 },
		 new Package
		 {
		     Id = 2, TrackingNumber = "DEF67890", SenderId = 1, Recipient = "Alice Williams",
		     OriginLocationId = 13, DestinationLocationId = 16,
		     Status = PackageStatus.Delivered,
		     CreatedAt  = new DateTime(2026, 4, 24, 14,  0, 0, DateTimeKind.Utc),
		     UpdatedAt  = new DateTime(2026, 4, 24, 16, 0, 0, DateTimeKind.Utc)
		 },
		 new Package
		 {
		     Id = 3, TrackingNumber = "GHI11223", SenderId = 1, Recipient = "Charlie Brown",
		     OriginLocationId = 15, DestinationLocationId = 17,
		     Status = PackageStatus.Delivered,
		     CreatedAt = new DateTime(2026, 4, 23,  9, 0, 0, DateTimeKind.Utc),
		     UpdatedAt = new DateTime(2026, 4, 23, 16, 0, 0, DateTimeKind.Utc)
		 }
		);
	}
}
