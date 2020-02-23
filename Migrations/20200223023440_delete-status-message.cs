using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Web_Product.Migrations
{
    public partial class deletestatusmessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Conversations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Conversations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
