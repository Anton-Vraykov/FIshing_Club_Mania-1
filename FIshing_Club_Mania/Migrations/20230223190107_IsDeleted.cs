using Microsoft.EntityFrameworkCore.Migrations;

namespace FIshing_Club_Mania.Migrations
{
    public partial class IsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "fishingPlace");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "fishingPlace",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "fishingPlace");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "fishingPlace",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
