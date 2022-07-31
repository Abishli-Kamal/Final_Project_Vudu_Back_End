using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class CreateTableMovieAndTomatometerAndMovieGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tomatometers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FilterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tomatometers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tomatometers_Filters_FilterId",
                        column: x => x.FilterId,
                        principalTable: "Filters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    BackImage = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    InfoMovie = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MainOptionId = table.Column<int>(nullable: true),
                    YearId = table.Column<int>(nullable: true),
                    RatingId = table.Column<int>(nullable: true),
                    StudioId = table.Column<int>(nullable: true),
                    TomoId = table.Column<int>(nullable: true),
                    TomatometerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_MainOptions_MainOptionId",
                        column: x => x.MainOptionId,
                        principalTable: "MainOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Ratings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Studios_StudioId",
                        column: x => x.StudioId,
                        principalTable: "Studios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Tomatometers_TomatometerId",
                        column: x => x.TomatometerId,
                        principalTable: "Tomatometers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Years_YearId",
                        column: x => x.YearId,
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(nullable: true),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieSubOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(nullable: true),
                    SubOptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSubOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieSubOptions_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieSubOptions_SubOptions_SubOptionId",
                        column: x => x.SubOptionId,
                        principalTable: "SubOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieId",
                table: "MovieGenres",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MainOptionId",
                table: "Movies",
                column: "MainOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_RatingId",
                table: "Movies",
                column: "RatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_StudioId",
                table: "Movies",
                column: "StudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_TomatometerId",
                table: "Movies",
                column: "TomatometerId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_YearId",
                table: "Movies",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubOptions_MovieId",
                table: "MovieSubOptions",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubOptions_SubOptionId",
                table: "MovieSubOptions",
                column: "SubOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tomatometers_FilterId",
                table: "Tomatometers",
                column: "FilterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "MovieSubOptions");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Tomatometers");
        }
    }
}
