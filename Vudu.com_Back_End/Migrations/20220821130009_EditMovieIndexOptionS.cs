using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class EditMovieIndexOptionS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieIndexOptions_IndexOptions_IndexOptionId",
                table: "MovieIndexOptions");

            migrationBuilder.AlterColumn<int>(
                name: "IndexOptionId",
                table: "MovieIndexOptions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieIndexOptions_IndexOptions_IndexOptionId",
                table: "MovieIndexOptions",
                column: "IndexOptionId",
                principalTable: "IndexOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieIndexOptions_IndexOptions_IndexOptionId",
                table: "MovieIndexOptions");

            migrationBuilder.AlterColumn<int>(
                name: "IndexOptionId",
                table: "MovieIndexOptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieIndexOptions_IndexOptions_IndexOptionId",
                table: "MovieIndexOptions",
                column: "IndexOptionId",
                principalTable: "IndexOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
