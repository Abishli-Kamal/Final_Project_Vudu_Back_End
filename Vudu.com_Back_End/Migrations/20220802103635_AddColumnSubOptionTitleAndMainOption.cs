using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class AddColumnSubOptionTitleAndMainOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainOptionId",
                table: "SubOptionTitles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubOptionTitles_MainOptionId",
                table: "SubOptionTitles",
                column: "MainOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubOptionTitles_MainOptions_MainOptionId",
                table: "SubOptionTitles",
                column: "MainOptionId",
                principalTable: "MainOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubOptionTitles_MainOptions_MainOptionId",
                table: "SubOptionTitles");

            migrationBuilder.DropIndex(
                name: "IX_SubOptionTitles_MainOptionId",
                table: "SubOptionTitles");

            migrationBuilder.DropColumn(
                name: "MainOptionId",
                table: "SubOptionTitles");
        }
    }
}
