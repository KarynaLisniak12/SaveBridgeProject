using Microsoft.EntityFrameworkCore.Migrations;

namespace SaveBridge.DataAccess.Migrations
{
    public partial class RenameFieldInRenovation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Renovations",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Renovations",
                newName: "Discription");
        }
    }
}
