using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class AddColumnMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TomatometerId",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_TomatometerId",
                table: "Movies",
                column: "TomatometerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Tomatometers_TomatometerId",
                table: "Movies",
                column: "TomatometerId",
                principalTable: "Tomatometers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Tomatometers_TomatometerId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_TomatometerId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "TomatometerId",
                table: "Movies");
        }
    }
}
