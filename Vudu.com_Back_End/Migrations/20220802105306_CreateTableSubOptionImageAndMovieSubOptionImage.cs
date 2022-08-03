using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class CreateTableSubOptionImageAndMovieSubOptionImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubOptionImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    MainOptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubOptionImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubOptionImages_MainOptions_MainOptionId",
                        column: x => x.MainOptionId,
                        principalTable: "MainOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieSubOptionImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(nullable: true),
                    ImageId = table.Column<int>(nullable: true),
                    SubOptionImageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSubOptionImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieSubOptionImages_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieSubOptionImages_SubOptionImages_SubOptionImageId",
                        column: x => x.SubOptionImageId,
                        principalTable: "SubOptionImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubOptionImages_MovieId",
                table: "MovieSubOptionImages",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubOptionImages_SubOptionImageId",
                table: "MovieSubOptionImages",
                column: "SubOptionImageId");

            migrationBuilder.CreateIndex(
                name: "IX_SubOptionImages_MainOptionId",
                table: "SubOptionImages",
                column: "MainOptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieSubOptionImages");

            migrationBuilder.DropTable(
                name: "SubOptionImages");
        }
    }
}
