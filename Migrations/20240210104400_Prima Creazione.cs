using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimaWeb.Migrations
{
    /// <inheritdoc />
    public partial class PrimaCreazione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registrazioni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cognome = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Sesso = table.Column<string>(type: "TEXT", nullable: true),
                    DataDiNascita = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Ruolo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrazioni", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registrazioni");
        }
    }
}
