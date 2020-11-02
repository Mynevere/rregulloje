using Microsoft.EntityFrameworkCore.Migrations;

namespace Rregulloje.Domain.Migrations
{
    public partial class AddCityAndFloorInIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Issue",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Floor",
                table: "Issue",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Issue");

            migrationBuilder.DropColumn(
                name: "Floor",
                table: "Issue");
        }
    }
}
