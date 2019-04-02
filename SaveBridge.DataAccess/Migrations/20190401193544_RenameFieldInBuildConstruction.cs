using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaveBridge.DataAccess.Migrations
{
    public partial class RenameFieldInBuildConstruction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingConstructions_Cities_CityId",
                table: "BuildingConstructions");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "BuildingConstructions");

            migrationBuilder.AlterColumn<Guid>(
                name: "CityId",
                table: "BuildingConstructions",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingConstructions_Cities_CityId",
                table: "BuildingConstructions",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingConstructions_Cities_CityId",
                table: "BuildingConstructions");

            migrationBuilder.AlterColumn<Guid>(
                name: "CityId",
                table: "BuildingConstructions",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "BuildingConstructions",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingConstructions_Cities_CityId",
                table: "BuildingConstructions",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
