using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inl1_WebApi.Migrations
{
    public partial class Categories_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryEntityId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryEntityId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryEntityId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CategoryEntityId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryEntityId",
                table: "Products",
                column: "CategoryEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryEntityId",
                table: "Products",
                column: "CategoryEntityId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
