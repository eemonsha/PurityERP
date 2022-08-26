using Microsoft.EntityFrameworkCore.Migrations;

namespace PurityERP.Migrations
{
    public partial class init212135 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalesRemainQty",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalesRemainQty",
                table: "Products");
        }
    }
}
