using Microsoft.EntityFrameworkCore.Migrations;

namespace Vudu.com_Back_End.Migrations
{
    public partial class CreateTableStudioAndAddColumnFilter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FilterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studios_Filters_FilterId",
                        column: x => x.FilterId,
                        principalTable: "Filters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studios_FilterId",
                table: "Studios",
                column: "FilterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studios");
        }
    }
}
