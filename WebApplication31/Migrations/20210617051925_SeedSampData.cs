using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication31.Migrations
{
    public partial class SeedSampData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepName", "Location" },
                values: new object[] { 1, "Admin", "Delhi" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepName", "Location" },
                values: new object[] { 2, "HR", "Mumbai" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepName", "Location" },
                values: new object[] { 3, "Sales", "Pune" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
