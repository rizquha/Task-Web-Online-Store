using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Web_Product.Migrations
{
    public partial class changenamemodelinpurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_carts_cartsid",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_cartsid",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "cartsid",
                table: "Purchase");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "Purchase",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Purchase",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CartId",
                table: "Purchase",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_carts_CartId",
                table: "Purchase",
                column: "CartId",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_carts_CartId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_CartId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Purchase");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "Purchase",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Purchase",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cartsid",
                table: "Purchase",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_cartsid",
                table: "Purchase",
                column: "cartsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_carts_cartsid",
                table: "Purchase",
                column: "cartsid",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
