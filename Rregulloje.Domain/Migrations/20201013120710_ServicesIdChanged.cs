using Microsoft.EntityFrameworkCore.Migrations;

namespace Rregulloje.Domain.Migrations
{
    public partial class ServicesIdChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceType_ServiceTypeId",
                table: "MinServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_MinServiceId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_MinServiceId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_MinServices_ServiceTypeId",
                table: "MinServices");

            migrationBuilder.DropColumn(
                name: "MinServiceId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceTypeId",
                table: "MinServices");

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "MinServices",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MinServices_ServiceId",
                table: "MinServices",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_ServiceId",
                table: "MinServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_ServiceId",
                table: "MinServices");

            migrationBuilder.DropIndex(
                name: "IX_MinServices_ServiceId",
                table: "MinServices");

            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "MinServices");

            migrationBuilder.AddColumn<int>(
                name: "MinServiceId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceTypeId",
                table: "MinServices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_MinServiceId",
                table: "Services",
                column: "MinServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_MinServices_ServiceTypeId",
                table: "MinServices",
                column: "ServiceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceType_ServiceTypeId",
                table: "MinServices",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_MinServiceId",
                table: "Services",
                column: "MinServiceId",
                principalTable: "MinServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
