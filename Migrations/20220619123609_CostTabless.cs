using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PurityERP.Migrations
{
    public partial class CostTabless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CostRegisters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdID = table.Column<int>(type: "int", nullable: false),
                    CostID = table.Column<int>(type: "int", nullable: false),
                    DateofCalculate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PerUnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostRegID = table.Column<int>(type: "int", nullable: false),
                    CostStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostRegisters", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostRegisters");
        }
    }
}
