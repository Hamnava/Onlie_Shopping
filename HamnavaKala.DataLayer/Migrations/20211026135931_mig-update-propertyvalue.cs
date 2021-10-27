using Microsoft.EntityFrameworkCore.Migrations;

namespace HamnavaKala.DataLayer.Migrations
{
    public partial class migupdatepropertyvalue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "productpropertyid",
                table: "PropertyValues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyValues_productpropertyid",
                table: "PropertyValues",
                column: "productpropertyid");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyValues_ProductProperties_productpropertyid",
                table: "PropertyValues",
                column: "productpropertyid",
                principalTable: "ProductProperties",
                principalColumn: "ProductPropertyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyValues_ProductProperties_productpropertyid",
                table: "PropertyValues");

            migrationBuilder.DropIndex(
                name: "IX_PropertyValues_productpropertyid",
                table: "PropertyValues");

            migrationBuilder.DropColumn(
                name: "productpropertyid",
                table: "PropertyValues");
        }
    }
}
