using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PurityERP.Migrations
{
    public partial class emo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnidId = table.Column<int>(type: "int", nullable: false),
                    PurchaseQuantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    RemainingQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryOuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductTittle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    InventoryQuantity = table.Column<int>(type: "int", nullable: false),
                    Worker = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryOuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTittle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostingPrice = table.Column<int>(type: "int", nullable: false),
                    SalesPrice = table.Column<int>(type: "int", nullable: false),
                    DiscountRate = table.Column<int>(type: "int", nullable: false),
                    InitialProductStockQty = table.Column<int>(type: "int", nullable: false),
                    RemainingQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "InventoryOuts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
