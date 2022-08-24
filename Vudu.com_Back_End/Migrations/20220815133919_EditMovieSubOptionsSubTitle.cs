using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class EditMovieSubOptionsSubTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionSubTitles_Movies_MovieId",
                table: "MovieSubOptionSubTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionSubTitles_SubOptionSubTitles_SubOptionSubTitleId",
                table: "MovieSubOptionSubTitles");

            migrationBuilder.AlterColumn<int>(
                name: "SubOptionSubTitleId",
                table: "MovieSubOptionSubTitles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieSubOptionSubTitles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionSubTitles_Movies_MovieId",
                table: "MovieSubOptionSubTitles",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionSubTitles_SubOptionSubTitles_SubOptionSubTitleId",
                table: "MovieSubOptionSubTitles",
                column: "SubOptionSubTitleId",
                principalTable: "SubOptionSubTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionSubTitles_Movies_MovieId",
                table: "MovieSubOptionSubTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionSubTitles_SubOptionSubTitles_SubOptionSubTitleId",
                table: "MovieSubOptionSubTitles");

            migrationBuilder.AlterColumn<int>(
                name: "SubOptionSubTitleId",
                table: "MovieSubOptionSubTitles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieSubOptionSubTitles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionSubTitles_Movies_MovieId",
                table: "MovieSubOptionSubTitles",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionSubTitles_SubOptionSubTitles_SubOptionSubTitleId",
                table: "MovieSubOptionSubTitles",
                column: "SubOptionSubTitleId",
                principalTable: "SubOptionSubTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
