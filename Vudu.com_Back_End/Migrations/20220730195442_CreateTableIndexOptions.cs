using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class CreateTableIndexOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieIndexOptions_IndexOption_IndexOptionId",
                table: "MovieIndexOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IndexOption",
                table: "IndexOption");

            migrationBuilder.RenameTable(
                name: "IndexOption",
                newName: "IndexOptions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndexOptions",
                table: "IndexOptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieIndexOptions_IndexOptions_IndexOptionId",
                table: "MovieIndexOptions",
                column: "IndexOptionId",
                principalTable: "IndexOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieIndexOptions_IndexOptions_IndexOptionId",
                table: "MovieIndexOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IndexOptions",
                table: "IndexOptions");

            migrationBuilder.RenameTable(
                name: "IndexOptions",
                newName: "IndexOption");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndexOption",
                table: "IndexOption",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieIndexOptions_IndexOption_IndexOptionId",
                table: "MovieIndexOptions",
                column: "IndexOptionId",
                principalTable: "IndexOption",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
