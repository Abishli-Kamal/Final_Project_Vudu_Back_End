using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class RemoveColumnMovieAndTomotameter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TomoId",
                table: "Movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TomatometerId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TomoId",
                table: "Movies",
                type: "int",
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
    }
}
