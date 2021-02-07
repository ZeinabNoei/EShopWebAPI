using Microsoft.EntityFrameworkCore.Migrations;

namespace EShopAPI.Migrations
{
    public partial class CitiFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
