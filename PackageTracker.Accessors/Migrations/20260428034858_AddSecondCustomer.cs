using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PackageTracker.Accessors.Migrations
{
    /// <inheritdoc />
    public partial class AddSecondCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Password", "Role", "Username" },
                values: new object[] { 3, "bob@test.com", "Bob", "Jones", "password123", 0, "bobcustomer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
