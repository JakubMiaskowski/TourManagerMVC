using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourManagerMVC.Infrastructure.Migrations
{
    public partial class Changevenuemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Venues",
                newName: "CreatedById");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Venues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "Venues",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Venues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Tours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "Tours",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Tours",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Concerts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Concerts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "Concerts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Concerts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Artists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Artists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "Artists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Artists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Addresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Addresses",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Concerts");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Concerts");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Concerts");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Concerts");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Venues",
                newName: "Type");
        }
    }
}
