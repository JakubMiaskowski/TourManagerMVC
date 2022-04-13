using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourManagerMVC.Infrastructure.Migrations
{
    public partial class ChangeContextConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Venues",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Venues");
        }
    }
}
