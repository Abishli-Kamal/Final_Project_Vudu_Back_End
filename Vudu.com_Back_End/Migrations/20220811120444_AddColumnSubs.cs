using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class AddColumnSubs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "MovieSubOptionTitles");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "MovieSubOptionSubTitles");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "MovieSubOptionImages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "MovieSubOptionTitles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "MovieSubOptionSubTitles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "MovieSubOptionImages",
                type: "int",
                nullable: true);
        }
    }
}
