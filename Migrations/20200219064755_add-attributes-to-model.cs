using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Web_Product.Migrations
{
    public partial class addattributestomodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "namaBarang",
                table: "purchases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "orderDate",
                table: "purchases",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "totalBarang",
                table: "purchases",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "namaBarang",
                table: "purchases");

            migrationBuilder.DropColumn(
                name: "orderDate",
                table: "purchases");

            migrationBuilder.DropColumn(
                name: "totalBarang",
                table: "purchases");
        }
    }
}
