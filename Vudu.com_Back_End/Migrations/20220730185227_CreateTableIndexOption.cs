using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class CreateTableIndexOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndexOption",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndexOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieIndexOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(nullable: true),
                    IndexOptionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieIndexOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieIndexOptions_IndexOption_IndexOptionId",
                        column: x => x.IndexOptionId,
                        principalTable: "IndexOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieIndexOptions_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieIndexOptions_IndexOptionId",
                table: "MovieIndexOptions",
                column: "IndexOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieIndexOptions_MovieId",
                table: "MovieIndexOptions",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieIndexOptions");

            migrationBuilder.DropTable(
                name: "IndexOption");
        }
    }
}
