using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planilhas.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisterDeposit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Receipt = table.Column<int>(type: "INTEGER", nullable: false),
                    Valor = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterDeposit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisterInputs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Talao = table.Column<int>(type: "INTEGER", nullable: false),
                    InputType = table.Column<int>(type: "INTEGER", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Dizimo = table.Column<double>(type: "REAL", nullable: true),
                    Oferta = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterInputs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisterOutputs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OutputType = table.Column<int>(type: "INTEGER", nullable: false),
                    Valor = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterOutputs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterDeposit");

            migrationBuilder.DropTable(
                name: "RegisterInputs");

            migrationBuilder.DropTable(
                name: "RegisterOutputs");
        }
    }
}
