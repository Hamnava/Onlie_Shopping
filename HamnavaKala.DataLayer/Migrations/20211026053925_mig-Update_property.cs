using Microsoft.EntityFrameworkCore.Migrations;

namespace HamnavaKala.DataLayer.Migrations
{
    public partial class migUpdate_property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ProductProperties",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ProductProperties");
        }
    }
}
