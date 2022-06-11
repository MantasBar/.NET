using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopManagementApp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
