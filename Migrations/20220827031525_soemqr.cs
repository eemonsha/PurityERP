﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PurityERP.Migrations
{
    public partial class soemqr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QrCategory",
                table: "QRs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QrCategory",
                table: "QRs");
        }
    }
}
