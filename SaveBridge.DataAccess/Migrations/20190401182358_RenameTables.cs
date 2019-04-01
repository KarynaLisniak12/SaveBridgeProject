using Microsoft.EntityFrameworkCore.Migrations;

namespace SaveBridge.DataAccess.Migrations
{
    public partial class RenameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Contries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Vibratins_BuildingConstructions_BuildingConstructionId",
                table: "Vibratins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vibratins",
                table: "Vibratins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contries",
                table: "Contries");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "BuildingConstructions");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "BuildingConstructions");

            migrationBuilder.RenameTable(
                name: "Vibratins",
                newName: "Vibrations");

            migrationBuilder.RenameTable(
                name: "Contries",
                newName: "Countries");

            migrationBuilder.RenameIndex(
                name: "IX_Vibratins_BuildingConstructionId",
                table: "Vibrations",
                newName: "IX_Vibrations_BuildingConstructionId");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "BuildingConstructions",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vibrations",
                table: "Vibrations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vibrations_BuildingConstructions_BuildingConstructionId",
                table: "Vibrations",
                column: "BuildingConstructionId",
                principalTable: "BuildingConstructions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Vibrations_BuildingConstructions_BuildingConstructionId",
                table: "Vibrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vibrations",
                table: "Vibrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "BuildingConstructions");

            migrationBuilder.RenameTable(
                name: "Vibrations",
                newName: "Vibratins");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Contries");

            migrationBuilder.RenameIndex(
                name: "IX_Vibrations_BuildingConstructionId",
                table: "Vibratins",
                newName: "IX_Vibratins_BuildingConstructionId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vibratins",
                table: "Vibratins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contries",
                table: "Contries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Contries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Contries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vibratins_BuildingConstructions_BuildingConstructionId",
                table: "Vibratins",
                column: "BuildingConstructionId",
                principalTable: "BuildingConstructions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
