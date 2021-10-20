using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HamnavaKala.DataLayer.Migrations
{
    public partial class migproductPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPrices",
                columns: table => new
                {
                    ProductpriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mainPrice = table.Column<int>(type: "int", nullable: false),
                    specialprice = table.Column<int>(type: "int", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false),
                    maxorderCount = table.Column<int>(type: "int", nullable: false),
                    CteateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateDiscount = table.Column<DateTime>(type: "datetime2", nullable: false),
                    productColor = table.Column<int>(type: "int", nullable: false),
                    productGurantee = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrices", x => x.ProductpriceId);
                    table.ForeignKey(
                        name: "FK_ProductPrices_ProductColors_productColor",
                        column: x => x.productColor,
                        principalTable: "ProductColors",
                        principalColumn: "productColorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductPrices_ProductGurantees_productGurantee",
                        column: x => x.productGurantee,
                        principalTable: "ProductGurantees",
                        principalColumn: "GuranteeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductPrices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_productColor",
                table: "ProductPrices",
                column: "productColor");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_productGurantee",
                table: "ProductPrices",
                column: "productGurantee");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_ProductId",
                table: "ProductPrices",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPrices");
        }
    }
}
