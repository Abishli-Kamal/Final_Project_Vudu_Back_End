using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class RemoveMovieGenreFiled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieIndexOptions_IndexOptions_IndexOptionId",
                table: "MovieIndexOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieIndexOptions_Movies_MovieId",
                table: "MovieIndexOptions");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieIndexOptions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IndexOptionId",
                table: "MovieIndexOptions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieIndexOptions_IndexOptions_IndexOptionId",
                table: "MovieIndexOptions",
                column: "IndexOptionId",
                principalTable: "IndexOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieIndexOptions_Movies_MovieId",
                table: "MovieIndexOptions",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieIndexOptions_IndexOptions_IndexOptionId",
                table: "MovieIndexOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieIndexOptions_Movies_MovieId",
                table: "MovieIndexOptions");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieIndexOptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "IndexOptionId",
                table: "MovieIndexOptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MovieIndexOptions_IndexOptions_IndexOptionId",
                table: "MovieIndexOptions",
                column: "IndexOptionId",
                principalTable: "IndexOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieIndexOptions_Movies_MovieId",
                table: "MovieIndexOptions",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
