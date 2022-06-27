using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SixMinApi.Migrations
{
    public partial class tableupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HotTo",
                table: "Commands",
                newName: "HowTo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HowTo",
                table: "Commands",
                newName: "HotTo");
        }
    }
}
