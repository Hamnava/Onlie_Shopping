using Microsoft.EntityFrameworkCore.Migrations;

namespace HamnavaKala.DataLayer.Migrations
{
    public partial class migsliderimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgSlider",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgSlider",
                table: "Sliders");
        }
    }
}
