using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class RemoveMovieSubOptionFiled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptions_Movies_MovieId",
                table: "MovieSubOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptions_SubOptions_SubOptionId",
                table: "MovieSubOptions");

            migrationBuilder.AlterColumn<int>(
                name: "SubOptionId",
                table: "MovieSubOptions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieSubOptions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptions_Movies_MovieId",
                table: "MovieSubOptions",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptions_SubOptions_SubOptionId",
                table: "MovieSubOptions",
                column: "SubOptionId",
                principalTable: "SubOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptions_Movies_MovieId",
                table: "MovieSubOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptions_SubOptions_SubOptionId",
                table: "MovieSubOptions");

            migrationBuilder.AlterColumn<int>(
                name: "SubOptionId",
                table: "MovieSubOptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieSubOptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptions_Movies_MovieId",
                table: "MovieSubOptions",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptions_SubOptions_SubOptionId",
                table: "MovieSubOptions",
                column: "SubOptionId",
                principalTable: "SubOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
