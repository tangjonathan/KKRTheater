using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterData.Migrations
{
    public partial class NewPeopleAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Directors",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Directors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Birthplace",
                table: "Directors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Actors",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Actors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Birthplace",
                table: "Actors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "Birthplace",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "Birthplace",
                table: "Actors");
        }
    }
}
