using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniCoreApi1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vendedores",
                columns: table => new
                {
                    idVendedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVendedor = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("vendedores", x => x.idVendedor);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    idVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idVendedor = table.Column<int>(type: "int", nullable: false),
                    ventas = table.Column<string>(type: "varchar(900)", unicode: false, maxLength: 900, nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    fechaVenta = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Venta__91431FE1C0001ED1", x => x.idVenta);
                    table.ForeignKey(
                        name: "FK_PersonasOrder",
                        column: x => x.idVendedor,
                        principalTable: "vendedores",
                        principalColumn: "idVendedor");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_idVendedor",
                table: "Ventas",
                column: "idVendedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "vendedores");
        }
    }
}
