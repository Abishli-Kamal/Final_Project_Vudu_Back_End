using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class CreateTableSubOptionSubTitleAndMovieSubOptionSubTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubOptionSubTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    MainOptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubOptionSubTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubOptionSubTitles_MainOptions_MainOptionId",
                        column: x => x.MainOptionId,
                        principalTable: "MainOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieSubOptionSubTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(nullable: true),
                    TitleId = table.Column<int>(nullable: true),
                    SubOptionSubTitleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSubOptionSubTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieSubOptionSubTitles_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieSubOptionSubTitles_SubOptionSubTitles_SubOptionSubTitleId",
                        column: x => x.SubOptionSubTitleId,
                        principalTable: "SubOptionSubTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubOptionSubTitles_MovieId",
                table: "MovieSubOptionSubTitles",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubOptionSubTitles_SubOptionSubTitleId",
                table: "MovieSubOptionSubTitles",
                column: "SubOptionSubTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubOptionSubTitles_MainOptionId",
                table: "SubOptionSubTitles",
                column: "MainOptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieSubOptionSubTitles");

            migrationBuilder.DropTable(
                name: "SubOptionSubTitles");
        }
    }
}
