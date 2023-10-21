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
            migrationBuilder.DropPrimaryKey(
                name: "PK_opcionesPedidos",
                table: "opcionesPedidos");

            migrationBuilder.DropColumn(
                name: "cantidad",
                table: "pedidos");

            migrationBuilder.AlterColumn<int>(
                name: "IdPedido",
                table: "opcionesPedidos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "OcionPedido",
                table: "opcionesPedidos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_opcionesPedidos",
                table: "opcionesPedidos",
                column: "OcionPedido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_opcionesPedidos",
                table: "opcionesPedidos");

            migrationBuilder.DropColumn(
                name: "OcionPedido",
                table: "opcionesPedidos");

            migrationBuilder.AddColumn<int>(
                name: "cantidad",
                table: "pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "IdPedido",
                table: "opcionesPedidos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_opcionesPedidos",
                table: "opcionesPedidos",
                column: "IdPedido");
        }
    }
}
