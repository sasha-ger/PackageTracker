using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PackageTracker.Accessors.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersAndPackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 12, "123 Main St, Seward, NE", 40.903599999999997, -97.097300000000004 },
                    { 13, "456 Oak Ave, Lincoln, NE", 40.813600000000001, -96.702600000000004 },
                    { 14, "789 Pine Rd, Omaha, NE", 41.252400000000002, -95.998000000000005 },
                    { 15, "321 Elm St, Waverly, NE", 40.9131, -96.531199999999998 },
                    { 16, "654 Maple Dr, Millard, NE", 41.189999999999998, -96.120000000000005 },
                    { 17, "987 Cedar Blvd, Greenwood, NE", 40.974899999999998, -96.433700000000002 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "jane@test.com", "Jane", "Doe", "password123", 0, "janedoe" },
                    { 2, "staff@test.com", "John", "Smith", "password123", 1, "johnstaff" }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "CreatedAt", "DestinationLocationId", "OriginLocationId", "Recipient", "SenderId", "Status", "TrackingNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 25, 10, 0, 0, 0, DateTimeKind.Utc), 14, 12, "Bob Johnson", 1, 0, "ABC12345", null },
                    { 2, new DateTime(2026, 4, 24, 14, 0, 0, 0, DateTimeKind.Utc), 16, 13, "Alice Williams", 1, 1, "DEF67890", new DateTime(2026, 4, 24, 15, 30, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2026, 4, 23, 9, 0, 0, 0, DateTimeKind.Utc), 17, 15, "Charlie Brown", 1, 2, "GHI11223", new DateTime(2026, 4, 23, 16, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
