using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class ChangeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Cinemas");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MovieCategory",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCategory",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Movies");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Cinemas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Cinemas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
