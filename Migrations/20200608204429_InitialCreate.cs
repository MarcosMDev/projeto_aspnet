using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Covid19.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrlImg = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Resume = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    References = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tips");
        }
    }
}
