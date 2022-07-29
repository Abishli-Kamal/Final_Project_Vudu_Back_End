using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class AddColumnSubOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SubOptions");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "SubOptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "SubOptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "SubOptions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "SubOptions");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "SubOptions");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "SubOptions");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SubOptions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
