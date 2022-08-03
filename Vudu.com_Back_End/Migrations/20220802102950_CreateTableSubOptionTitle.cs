using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class CreateTableSubOptionTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MainOptions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SubOptionTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubOptionTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieSubOptionTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(nullable: true),
                    TitleId = table.Column<int>(nullable: true),
                    SubOptionTitleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSubOptionTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieSubOptionTitles_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieSubOptionTitles_SubOptionTitles_SubOptionTitleId",
                        column: x => x.SubOptionTitleId,
                        principalTable: "SubOptionTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubOptionTitles_MovieId",
                table: "MovieSubOptionTitles",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubOptionTitles_SubOptionTitleId",
                table: "MovieSubOptionTitles",
                column: "SubOptionTitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieSubOptionTitles");

            migrationBuilder.DropTable(
                name: "SubOptionTitles");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MainOptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
