using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iwp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    haberId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    haberBasligi = table.Column<string>(type: "TEXT", nullable: true),
                    haberIcerigi = table.Column<string>(type: "TEXT", nullable: true),
                    haberResmi = table.Column<string>(type: "TEXT", nullable: true),
                    haberYazari = table.Column<string>(type: "TEXT", nullable: true),
                    haberTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    haberTiklanmasi = table.Column<int>(type: "INTEGER", nullable: false),
                    haberKaynagi = table.Column<string>(type: "TEXT", nullable: true),
                    categoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.haberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
