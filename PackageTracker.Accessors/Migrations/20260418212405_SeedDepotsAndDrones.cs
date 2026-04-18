using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PackageTracker.Accessors.Migrations
{
    /// <inheritdoc />
    public partial class SeedDepotsAndDrones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 1, null, 40.824939999999998, -97.096590000000006 },
                    { 2, null, 40.826540000000001, -96.899500000000003 },
                    { 3, null, 40.860590000000002, -96.729060000000004 },
                    { 4, null, 40.900440000000003, -96.553669999999997 },
                    { 5, null, 40.965670000000003, -96.403750000000002 },
                    { 6, null, 41.086590000000001, -96.275989999999993 },
                    { 7, null, 41.181780000000003, -96.120009999999994 },
                    { 8, null, 41.222410000000004, -95.947500000000005 },
                    { 9, null, 40.813279999999999, -96.68186 },
                    { 10, null, 40.812989999999999, -96.607050000000001 },
                    { 11, null, 40.735999999999997, -96.604479999999995 }
                });

            migrationBuilder.InsertData(
                table: "Depots",
                columns: new[] { "Id", "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Seward Depot" },
                    { 2, 2, "Pawnee Lake Depot" },
                    { 3, 3, "Lincoln Northwest Depot" },
                    { 4, 4, "Waverly Depot" },
                    { 5, 5, "Greenwood Depot" },
                    { 6, 6, "Melia Depot" },
                    { 7, 7, "Millard Depot" },
                    { 8, 8, "Omaha Depot" },
                    { 9, 9, "Depot at 27th and O St" },
                    { 10, 10, "Depot at 84th and O St" },
                    { 11, 11, "Depot at 84th St and Hwy 2" }
                });

            migrationBuilder.InsertData(
                table: "Drones",
                columns: new[] { "Id", "CurrentDepotId", "CurrentPackageId", "DestinationDepotId", "EstimatedArrivalTime", "HomeDepotId", "Status" },
                values: new object[,]
                {
                    { 1, 1, null, null, null, 1, 0 },
                    { 2, 1, null, null, null, 1, 0 },
                    { 3, 1, null, null, null, 1, 0 },
                    { 4, 2, null, null, null, 2, 0 },
                    { 5, 2, null, null, null, 2, 0 },
                    { 6, 2, null, null, null, 2, 0 },
                    { 7, 3, null, null, null, 3, 0 },
                    { 8, 3, null, null, null, 3, 0 },
                    { 9, 3, null, null, null, 3, 0 },
                    { 10, 4, null, null, null, 4, 0 },
                    { 11, 4, null, null, null, 4, 0 },
                    { 12, 4, null, null, null, 4, 0 },
                    { 13, 5, null, null, null, 5, 0 },
                    { 14, 5, null, null, null, 5, 0 },
                    { 15, 5, null, null, null, 5, 0 },
                    { 16, 6, null, null, null, 6, 0 },
                    { 17, 6, null, null, null, 6, 0 },
                    { 18, 6, null, null, null, 6, 0 },
                    { 19, 7, null, null, null, 7, 0 },
                    { 20, 7, null, null, null, 7, 0 },
                    { 21, 7, null, null, null, 7, 0 },
                    { 22, 8, null, null, null, 8, 0 },
                    { 23, 8, null, null, null, 8, 0 },
                    { 24, 8, null, null, null, 8, 0 },
                    { 25, 9, null, null, null, 9, 0 },
                    { 26, 9, null, null, null, 9, 0 },
                    { 27, 9, null, null, null, 9, 0 },
                    { 28, 10, null, null, null, 10, 0 },
                    { 29, 10, null, null, null, 10, 0 },
                    { 30, 10, null, null, null, 10, 0 },
                    { 31, 11, null, null, null, 11, 0 },
                    { 32, 11, null, null, null, 11, 0 },
                    { 33, 11, null, null, null, 11, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Drones",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Depots",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
