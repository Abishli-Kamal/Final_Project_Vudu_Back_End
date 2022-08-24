using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class EditSubOptionsSubTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubOptionSubTitles_MainOptions_MainOptionId",
                table: "SubOptionSubTitles");

            migrationBuilder.AlterColumn<int>(
                name: "MainOptionId",
                table: "SubOptionSubTitles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SubOptionSubTitles_MainOptions_MainOptionId",
                table: "SubOptionSubTitles",
                column: "MainOptionId",
                principalTable: "MainOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubOptionSubTitles_MainOptions_MainOptionId",
                table: "SubOptionSubTitles");

            migrationBuilder.AlterColumn<int>(
                name: "MainOptionId",
                table: "SubOptionSubTitles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubOptionSubTitles_MainOptions_MainOptionId",
                table: "SubOptionSubTitles",
                column: "MainOptionId",
                principalTable: "MainOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
