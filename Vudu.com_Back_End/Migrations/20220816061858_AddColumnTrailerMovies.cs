using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class AddColumnTrailerMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieIndexOptions_Movies_MovieId",
                table: "MovieIndexOptions");

            migrationBuilder.DropTable(
                name: "Trailers");

            migrationBuilder.AddColumn<string>(
                name: "Trailer",
                table: "Movies",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieIndexOptions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "FK_MovieIndexOptions_Movies_MovieId",
                table: "MovieIndexOptions");

            migrationBuilder.DropColumn(
                name: "Trailer",
                table: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieIndexOptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Trailers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trailers_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trailers_MovieId",
                table: "Trailers",
                column: "MovieId");

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
