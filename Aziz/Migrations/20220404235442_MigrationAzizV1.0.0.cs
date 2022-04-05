using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aziz.Migrations
{
    public partial class MigrationAzizV100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contrat",
                columns: table => new
                {
                    ContratId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContratType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrat", x => x.ContratId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contrat");
        }
    }
}
