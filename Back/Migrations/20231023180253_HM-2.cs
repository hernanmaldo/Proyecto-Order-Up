using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class HM2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IngredientesOpcion",
                columns: table => new
                {
                    ingredientesIdIngredientes = table.Column<int>(type: "int", nullable: false),
                    opcionesIdOpcion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientesOpcion", x => new { x.ingredientesIdIngredientes, x.opcionesIdOpcion });
                    table.ForeignKey(
                        name: "FK_IngredientesOpcion_ingredientes_ingredientesIdIngredientes",
                        column: x => x.ingredientesIdIngredientes,
                        principalTable: "ingredientes",
                        principalColumn: "IdIngredientes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientesOpcion_opciones_opcionesIdOpcion",
                        column: x => x.opcionesIdOpcion,
                        principalTable: "opciones",
                        principalColumn: "IdOpcion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesOpcion_opcionesIdOpcion",
                table: "IngredientesOpcion",
                column: "opcionesIdOpcion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientesOpcion");
        }
    }
}
