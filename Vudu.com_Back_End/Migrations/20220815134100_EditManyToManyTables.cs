using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class EditManyToManyTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionImages_Movies_MovieId",
                table: "MovieSubOptionImages");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionImages_SubOptionImages_SubOptionImageId",
                table: "MovieSubOptionImages");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionTitles_Movies_MovieId",
                table: "MovieSubOptionTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionTitles_SubOptionTitles_SubOptionTitleId",
                table: "MovieSubOptionTitles");

            migrationBuilder.AlterColumn<int>(
                name: "SubOptionTitleId",
                table: "MovieSubOptionTitles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieSubOptionTitles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubOptionImageId",
                table: "MovieSubOptionImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieSubOptionImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieGenres",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "MovieGenres",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionImages_Movies_MovieId",
                table: "MovieSubOptionImages",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionImages_SubOptionImages_SubOptionImageId",
                table: "MovieSubOptionImages",
                column: "SubOptionImageId",
                principalTable: "SubOptionImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionTitles_Movies_MovieId",
                table: "MovieSubOptionTitles",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionTitles_SubOptionTitles_SubOptionTitleId",
                table: "MovieSubOptionTitles",
                column: "SubOptionTitleId",
                principalTable: "SubOptionTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionImages_Movies_MovieId",
                table: "MovieSubOptionImages");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionImages_SubOptionImages_SubOptionImageId",
                table: "MovieSubOptionImages");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionTitles_Movies_MovieId",
                table: "MovieSubOptionTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSubOptionTitles_SubOptionTitles_SubOptionTitleId",
                table: "MovieSubOptionTitles");

            migrationBuilder.AlterColumn<int>(
                name: "SubOptionTitleId",
                table: "MovieSubOptionTitles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieSubOptionTitles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SubOptionImageId",
                table: "MovieSubOptionImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieSubOptionImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieGenres",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "MovieGenres",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionImages_Movies_MovieId",
                table: "MovieSubOptionImages",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionImages_SubOptionImages_SubOptionImageId",
                table: "MovieSubOptionImages",
                column: "SubOptionImageId",
                principalTable: "SubOptionImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionTitles_Movies_MovieId",
                table: "MovieSubOptionTitles",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSubOptionTitles_SubOptionTitles_SubOptionTitleId",
                table: "MovieSubOptionTitles",
                column: "SubOptionTitleId",
                principalTable: "SubOptionTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
