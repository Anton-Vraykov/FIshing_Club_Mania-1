using Microsoft.EntityFrameworkCore.Migrations;

namespace FIshing_Club_Mania.Migrations
{
    public partial class AddDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "fishingPlace",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "fishingPlace");
        }
    }
}
