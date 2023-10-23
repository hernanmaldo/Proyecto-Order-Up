using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "opciones",
                columns: table => new
                {
                    IdOpcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opciones", x => x.IdOpcion);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ingredientes",
                columns: table => new
                {
                    IdIngredientes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OpcionIdOpcion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredientes", x => x.IdIngredientes);
                    table.ForeignKey(
                        name: "FK_ingredientes_opciones_OpcionIdOpcion",
                        column: x => x.OpcionIdOpcion,
                        principalTable: "opciones",
                        principalColumn: "IdOpcion");
                });

            migrationBuilder.CreateTable(
                name: "reporte",
                columns: table => new
                {
                    IdReporte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaRealizado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Usuarioid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reporte", x => x.IdReporte);
                    table.ForeignKey(
                        name: "FK_reporte_usuarios_Usuarioid",
                        column: x => x.Usuarioid,
                        principalTable: "usuarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ingredientesOpciones",
                columns: table => new
                {
                    IdIngrentesOpcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOpcion = table.Column<int>(type: "int", nullable: false),
                    IdIngredientes = table.Column<int>(type: "int", nullable: false),
                    opcionIdOpcion = table.Column<int>(type: "int", nullable: false),
                    ingredientesIdIngredientes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredientesOpciones", x => x.IdIngrentesOpcion);
                    table.ForeignKey(
                        name: "FK_ingredientesOpciones_ingredientes_ingredientesIdIngredientes",
                        column: x => x.ingredientesIdIngredientes,
                        principalTable: "ingredientes",
                        principalColumn: "IdIngredientes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ingredientesOpciones_opciones_opcionIdOpcion",
                        column: x => x.opcionIdOpcion,
                        principalTable: "opciones",
                        principalColumn: "IdOpcion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cargado = table.Column<bool>(type: "bit", nullable: false),
                    ReporteIdReporte = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_pedidos_reporte_ReporteIdReporte",
                        column: x => x.ReporteIdReporte,
                        principalTable: "reporte",
                        principalColumn: "IdReporte");
                });

            migrationBuilder.CreateTable(
                name: "opcionesPedidos",
                columns: table => new
                {
                    OcionPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPedido = table.Column<int>(type: "int", nullable: false),
                    IdOpcion = table.Column<int>(type: "int", nullable: false),
                    OpcionIdOpcion = table.Column<int>(type: "int", nullable: false),
                    PedidoIdPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opcionesPedidos", x => x.OcionPedido);
                    table.ForeignKey(
                        name: "FK_opcionesPedidos_opciones_OpcionIdOpcion",
                        column: x => x.OpcionIdOpcion,
                        principalTable: "opciones",
                        principalColumn: "IdOpcion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_opcionesPedidos_pedidos_PedidoIdPedido",
                        column: x => x.PedidoIdPedido,
                        principalTable: "pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reportePedidos",
                columns: table => new
                {
                    IdReporte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reporteIdReporte = table.Column<int>(type: "int", nullable: false),
                    IdPedido = table.Column<int>(type: "int", nullable: false),
                    pedidoIdPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reportePedidos", x => x.IdReporte);
                    table.ForeignKey(
                        name: "FK_reportePedidos_pedidos_pedidoIdPedido",
                        column: x => x.pedidoIdPedido,
                        principalTable: "pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reportePedidos_reporte_reporteIdReporte",
                        column: x => x.reporteIdReporte,
                        principalTable: "reporte",
                        principalColumn: "IdReporte",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ingredientes_OpcionIdOpcion",
                table: "ingredientes",
                column: "OpcionIdOpcion");

            migrationBuilder.CreateIndex(
                name: "IX_ingredientesOpciones_ingredientesIdIngredientes",
                table: "ingredientesOpciones",
                column: "ingredientesIdIngredientes");

            migrationBuilder.CreateIndex(
                name: "IX_ingredientesOpciones_opcionIdOpcion",
                table: "ingredientesOpciones",
                column: "opcionIdOpcion");

            migrationBuilder.CreateIndex(
                name: "IX_opcionesPedidos_OpcionIdOpcion",
                table: "opcionesPedidos",
                column: "OpcionIdOpcion");

            migrationBuilder.CreateIndex(
                name: "IX_opcionesPedidos_PedidoIdPedido",
                table: "opcionesPedidos",
                column: "PedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_ReporteIdReporte",
                table: "pedidos",
                column: "ReporteIdReporte");

            migrationBuilder.CreateIndex(
                name: "IX_reporte_Usuarioid",
                table: "reporte",
                column: "Usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_reportePedidos_pedidoIdPedido",
                table: "reportePedidos",
                column: "pedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_reportePedidos_reporteIdReporte",
                table: "reportePedidos",
                column: "reporteIdReporte");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ingredientesOpciones");

            migrationBuilder.DropTable(
                name: "opcionesPedidos");

            migrationBuilder.DropTable(
                name: "reportePedidos");

            migrationBuilder.DropTable(
                name: "ingredientes");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "opciones");

            migrationBuilder.DropTable(
                name: "reporte");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
