using Microsoft.EntityFrameworkCore.Migrations;

namespace Rregulloje.Domain.Migrations
{
    public partial class ChangeApartmentNumberName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppartmentNumber",
                table: "Issue");

            migrationBuilder.AddColumn<string>(
                name: "ApartmentNumber",
                table: "Issue",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApartmentNumber",
                table: "Issue");

            migrationBuilder.AddColumn<string>(
                name: "AppartmentNumber",
                table: "Issue",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
