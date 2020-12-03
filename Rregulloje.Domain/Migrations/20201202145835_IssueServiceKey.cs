using Microsoft.EntityFrameworkCore.Migrations;

namespace Rregulloje.Domain.Migrations
{
    public partial class IssueServiceKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Issue",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Issue_ServiceId",
                table: "Issue",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Issue_ServiceId",
                table: "Issue",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issue_ServiceId",
                table: "Issue");

            migrationBuilder.DropIndex(
                name: "IX_Issue_ServiceId",
                table: "Issue");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Issue");
        }
    }
}
