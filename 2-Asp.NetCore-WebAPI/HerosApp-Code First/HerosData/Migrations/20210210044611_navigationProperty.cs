using Microsoft.EntityFrameworkCore.Migrations;

namespace HerosData.Migrations
{
    public partial class navigationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SuperPowers_Ownerid",
                table: "SuperPowers");

            migrationBuilder.CreateIndex(
                name: "IX_SuperPowers_Ownerid",
                table: "SuperPowers",
                column: "Ownerid",
                unique: true,
                filter: "[Ownerid] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SuperPowers_Ownerid",
                table: "SuperPowers");

            migrationBuilder.CreateIndex(
                name: "IX_SuperPowers_Ownerid",
                table: "SuperPowers",
                column: "Ownerid");
        }
    }
}
