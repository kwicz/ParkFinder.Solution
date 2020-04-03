using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkFinder.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    DateEstablished = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Area", "DateEstablished", "Description", "Location", "Name" },
                values: new object[] { 1, "47,389.67 acres (191.8 km2)", "January 1, 2010", "Set in Downtown Portland, this park feature lots of computers, feral young programmers, and hand sanitizer.", "Portland, OR", "Epicodus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
