using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class ConfigRelationshipForUserAndInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Infos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InfoId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Infos_ApplicationUserId",
                table: "Infos",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Infos_AspNetUsers_ApplicationUserId",
                table: "Infos",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Infos_AspNetUsers_ApplicationUserId",
                table: "Infos");

            migrationBuilder.DropIndex(
                name: "IX_Infos_ApplicationUserId",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "InfoId",
                table: "AspNetUsers");
        }
    }
}
