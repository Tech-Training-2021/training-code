using Microsoft.EntityFrameworkCore.Migrations;

namespace HerosData.Migrations
{
    public partial class Initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "superpeople",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    WorkName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Hideout = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_superpeople", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "superpeople");
        }
    }
}
