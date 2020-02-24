using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Web_Product.Migrations
{
    public partial class addmodelconversationtodatabasefirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_chat",
                table: "chat");

            migrationBuilder.DropColumn(
                name: "uuid",
                table: "chat");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "chat",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chat",
                table: "chat",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_chat",
                table: "chat");

            migrationBuilder.DropColumn(
                name: "id",
                table: "chat");

            migrationBuilder.AddColumn<Guid>(
                name: "uuid",
                table: "chat",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_chat",
                table: "chat",
                column: "uuid");
        }
    }
}
