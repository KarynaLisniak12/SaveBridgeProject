using Microsoft.EntityFrameworkCore.Migrations;

namespace SaveBridge.DataAccess.Migrations
{
    public partial class AddCoordinatesToBuilding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "BuildingConstructions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "BuildingConstructions",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "BuildingConstructions");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "BuildingConstructions");
        }
    }
}
