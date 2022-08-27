using Microsoft.EntityFrameworkCore.Migrations;

namespace PurityERP.Migrations
{
    public partial class updQRs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QRCodes_Products_ProductId",
                table: "QRCodes");

            migrationBuilder.DropIndex(
                name: "IX_QRCodes_ProductId",
                table: "QRCodes");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "QRs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "QRs");

            migrationBuilder.CreateIndex(
                name: "IX_QRCodes_ProductId",
                table: "QRCodes",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_QRCodes_Products_ProductId",
                table: "QRCodes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
