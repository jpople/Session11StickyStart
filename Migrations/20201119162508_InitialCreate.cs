using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace stickynotes.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sticky",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NoteTitle = table.Column<string>(type: "TEXT", nullable: true),
                    NoteText = table.Column<string>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: false),
                    PostTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sticky", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sticky");
        }
    }
}
