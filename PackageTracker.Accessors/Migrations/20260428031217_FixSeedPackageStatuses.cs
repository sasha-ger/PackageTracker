using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PackageTracker.Accessors.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedPackageStatuses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Status", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2026, 4, 25, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Status", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2026, 4, 24, 16, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Status", "UpdatedAt" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Status", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2026, 4, 24, 15, 30, 0, 0, DateTimeKind.Utc) });
        }
    }
}
