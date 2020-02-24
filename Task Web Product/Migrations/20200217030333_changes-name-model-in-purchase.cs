using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Web_Product.Migrations
{
    public partial class changesnamemodelinpurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_carts_CartsId",
                table: "items");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_carts_CartId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_CartId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Purchase");

            migrationBuilder.AddColumn<int>(
                name: "CartsId",
                table: "Purchase",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CartsId",
                table: "items",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CartsId",
                table: "Purchase",
                column: "CartsId");

            migrationBuilder.AddForeignKey(
                name: "FK_items_carts_CartsId",
                table: "items",
                column: "CartsId",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_carts_CartsId",
                table: "Purchase",
                column: "CartsId",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_carts_CartsId",
                table: "items");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_carts_CartsId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_CartsId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "CartsId",
                table: "Purchase");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Purchase",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CartsId",
                table: "items",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CartId",
                table: "Purchase",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_items_carts_CartsId",
                table: "items",
                column: "CartsId",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_carts_CartId",
                table: "Purchase",
                column: "CartId",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
