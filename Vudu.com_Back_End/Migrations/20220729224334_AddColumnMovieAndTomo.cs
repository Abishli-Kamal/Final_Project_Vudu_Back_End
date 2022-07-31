using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class AddColumnMovieAndTomo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tomatometers");

            migrationBuilder.AddColumn<int>(
                name: "Title",
                table: "Tomatometers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RottenTomatoes",
                table: "Movies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Tomatometers");

            migrationBuilder.DropColumn(
                name: "RottenTomatoes",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tomatometers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
