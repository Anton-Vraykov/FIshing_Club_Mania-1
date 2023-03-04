using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIshing_Club_Mania.Migrations
{
    public partial class FirstMigrashion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fishingPlace",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PictureURL = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Reservation = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fishingPlace", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fishingPlace");
        }
    }
}
