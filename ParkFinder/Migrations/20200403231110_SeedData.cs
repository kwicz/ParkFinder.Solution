using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkFinder.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Area", "DateEstablished", "Description", "Location", "Name" },
                values: new object[] { 60, "47,389.67 acres (191.8 km2)", "January 1, 2010", "Set in Downtown Portland, this park feature lots of computers, feral young programmers, and hand sanitizer.", "Portland", "Epicodus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 60);
        }
    }
}
