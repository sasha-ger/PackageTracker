# Group 6 - PackageTracker

Group Members: Sasha Gerasimov, Subbu Kundoor, Kanwal Lotay, Emma Rhode, Aden Smith

## Database Setup
This project uses MS SQL Server with Entity Framework Core.

1. Install SQL Server locally or use a Docker container
2. Create your local config files by copying the example files and filling in your credentials:
   - Copy `PackageTracker.Managers/appsettings.example.json` → `PackageTracker.Managers/appsettings.json`
   - Copy `PackageTracker.Accessors/appsettings.example.json` → `PackageTracker.Accessors/appsettings.json`
3. Install the EF Core CLI tools if you haven't already:
   ```bash
   dotnet tool install --global dotnet-ef
   ```
4. Apply the migrations to create your local database:
   ```bash
   dotnet ef database update --project PackageTracker.Accessors --startup-project PackageTracker.Managers
   ```

## Project Description
Mo's Drones is a courier service using small unmanned aerial systems (SUAS) to deliver
packages within the Lincoln and Omaha, Nebraska, areas. When a customer needs a package to
be delivered, a SUAS is dispatched from a nearby depot to pick up the package. 

Because the SUAS has a limited range, there are depots every ten miles along I-80 between
Seward and the Missouri River. There are also depots in Lincoln at the intersection of O Street
and 27th Street, at the intersection of O Street and 84th Street, and at the intersection of 84th
Street and Nebraska Highway 2. When a SUAS with a package arrives at a depot, the package is
handed off to another SUAS which will carry the package to the next depot or the destination (if
the destination is within range). 

A customer (both the sender and the receiver) should be able to observe the status of a delivery,
to include the point of origin and the destination, when the SUAS was dispatched, when the
SUAS picked up the package, when the package was handed off to another SUAS at each depot
visited, and when the package was delivered. A customer should also be able to generate a
delivery request, which will cause a SUAS to be dispatched automatically to pick up the
package. 

The Mo's Drones staff should be able to observe where each SUAS is, whether at a depot,
between depots, en route to/from a customer, or at a customer's location. The staff should be able
to observe which package is aboard which SUAS. Just as the customers can, the staff should be
able to observe a package's status. While dispatching a SUAS to pick up a package is automatic,
the staff should be able to dispatch an empty SUAS from one depot to another. 

Current information about the SUAS & package locations & destinations must be recoverable
after a power outage. 

The system may be implemented in text-mode or GUI-mode.