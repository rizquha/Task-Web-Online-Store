using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Web_Product.Migrations
{
    public partial class changesdatatypephonenumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_carts_CartsId",
                table: "Purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase");

            migrationBuilder.RenameTable(
                name: "Purchase",
                newName: "purchases");

            migrationBuilder.RenameIndex(
                name: "IX_Purchase_CartsId",
                table: "purchases",
                newName: "IX_purchases_CartsId");

            migrationBuilder.AlterColumn<string>(
                name: "phoneNumber",
                table: "purchases",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_purchases",
                table: "purchases",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_purchases_carts_CartsId",
                table: "purchases",
                column: "CartsId",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_purchases_carts_CartsId",
                table: "purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_purchases",
                table: "purchases");

            migrationBuilder.RenameTable(
                name: "purchases",
                newName: "Purchase");

            migrationBuilder.RenameIndex(
                name: "IX_purchases_CartsId",
                table: "Purchase",
                newName: "IX_Purchase_CartsId");

            migrationBuilder.AlterColumn<int>(
                name: "phoneNumber",
                table: "Purchase",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_carts_CartsId",
                table: "Purchase",
                column: "CartsId",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
