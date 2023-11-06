using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProject.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_PorductId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductColor",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductType",
                table: "ProductTypes",
                newName: "FoodType");

            migrationBuilder.RenameColumn(
                name: "ProductTypeId",
                table: "Products",
                newName: "FoodTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                newName: "IX_Products_FoodTypeId");

            migrationBuilder.RenameColumn(
                name: "PorductId",
                table: "OrderDetails",
                newName: "FoodId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_PorductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_FoodId",
                table: "OrderDetails",
                column: "FoodId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_FoodTypeId",
                table: "Products",
                column: "FoodTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_FoodId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_FoodTypeId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "FoodType",
                table: "ProductTypes",
                newName: "ProductType");

            migrationBuilder.RenameColumn(
                name: "FoodTypeId",
                table: "Products",
                newName: "ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_FoodTypeId",
                table: "Products",
                newName: "IX_Products_ProductTypeId");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "OrderDetails",
                newName: "PorductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_FoodId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_PorductId");

            migrationBuilder.AddColumn<string>(
                name: "ProductColor",
                table: "Products",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_PorductId",
                table: "OrderDetails",
                column: "PorductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
