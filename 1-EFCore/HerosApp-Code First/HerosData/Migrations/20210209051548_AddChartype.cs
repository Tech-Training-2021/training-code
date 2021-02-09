using Microsoft.EntityFrameworkCore.Migrations;

namespace HerosData.Migrations
{
    public partial class AddChartype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CharType",
                table: "superpeople",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharType",
                table: "superpeople");
        }
    }
}
