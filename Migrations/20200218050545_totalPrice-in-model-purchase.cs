using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Web_Product.Migrations
{
    public partial class totalPriceinmodelpurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "totalPrice",
                table: "purchases",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "totalPrice",
                table: "purchases");
        }
    }
}
