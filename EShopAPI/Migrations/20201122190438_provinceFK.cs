using Microsoft.EntityFrameworkCore.Migrations;

namespace EShopAPI.Migrations
{
    public partial class provinceFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Province_City_CityID",
                table: "Province");

            migrationBuilder.DropIndex(
                name: "IX_Province_CityID",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Province");

            migrationBuilder.AddColumn<int>(
                name: "ProvinceID",
                table: "City",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceID",
                table: "City",
                column: "ProvinceID");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Province_ProvinceID",
                table: "City",
                column: "ProvinceID",
                principalTable: "Province",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Province_ProvinceID",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_ProvinceID",
                table: "City");

            migrationBuilder.DropColumn(
                name: "ProvinceID",
                table: "City");

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Province",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Province_CityID",
                table: "Province",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Province_City_CityID",
                table: "Province",
                column: "CityID",
                principalTable: "City",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
