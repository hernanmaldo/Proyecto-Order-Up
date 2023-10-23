using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class HM1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ingredientes_opciones_OpcionIdOpcion",
                table: "ingredientes");

            migrationBuilder.DropIndex(
                name: "IX_ingredientes_OpcionIdOpcion",
                table: "ingredientes");

            migrationBuilder.DropColumn(
                name: "OpcionIdOpcion",
                table: "ingredientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OpcionIdOpcion",
                table: "ingredientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ingredientes_OpcionIdOpcion",
                table: "ingredientes",
                column: "OpcionIdOpcion");

            migrationBuilder.AddForeignKey(
                name: "FK_ingredientes_opciones_OpcionIdOpcion",
                table: "ingredientes",
                column: "OpcionIdOpcion",
                principalTable: "opciones",
                principalColumn: "IdOpcion");
        }
    }
}
