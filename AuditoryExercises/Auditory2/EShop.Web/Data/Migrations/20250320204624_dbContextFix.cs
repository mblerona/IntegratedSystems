using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class dbContextFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_EShopApplicationUserId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCart_Product_ProductId",
                table: "ProductInShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCart_ShoppingCart_ShoppingCartId",
                table: "ProductInShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_AspNetUsers_OwnerId",
                table: "ShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInShoppingCart",
                table: "ProductInShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "ShoppingCart",
                newName: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "ProductInShoppingCart",
                newName: "ProductInShoppingCarts");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCart_OwnerId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCart_ShoppingCartId",
                table: "ProductInShoppingCarts",
                newName: "IX_ProductInShoppingCarts_ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCart_ProductId",
                table: "ProductInShoppingCarts",
                newName: "IX_ProductInShoppingCarts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_EShopApplicationUserId",
                table: "Products",
                newName: "IX_Products_EShopApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_Products_ProductId",
                table: "ProductInShoppingCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_ShoppingCartId",
                table: "ProductInShoppingCarts",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_EShopApplicationUserId",
                table: "Products",
                column: "EShopApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_OwnerId",
                table: "ShoppingCarts",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_Products_ProductId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_ShoppingCartId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_EShopApplicationUserId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_OwnerId",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "ShoppingCart");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "ProductInShoppingCarts",
                newName: "ProductInShoppingCart");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_OwnerId",
                table: "ShoppingCart",
                newName: "IX_ShoppingCart_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_EShopApplicationUserId",
                table: "Product",
                newName: "IX_Product_EShopApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCarts_ShoppingCartId",
                table: "ProductInShoppingCart",
                newName: "IX_ProductInShoppingCart_ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCarts_ProductId",
                table: "ProductInShoppingCart",
                newName: "IX_ProductInShoppingCart_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInShoppingCart",
                table: "ProductInShoppingCart",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_EShopApplicationUserId",
                table: "Product",
                column: "EShopApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCart_Product_ProductId",
                table: "ProductInShoppingCart",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCart_ShoppingCart_ShoppingCartId",
                table: "ProductInShoppingCart",
                column: "ShoppingCartId",
                principalTable: "ShoppingCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_AspNetUsers_OwnerId",
                table: "ShoppingCart",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
