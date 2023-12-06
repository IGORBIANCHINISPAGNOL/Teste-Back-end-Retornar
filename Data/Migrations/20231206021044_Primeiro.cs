using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Primeiro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_cliente",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    xNomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    xTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    xCPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    xEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cliente", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "tb_numerosGerados",
                columns: table => new
                {
                    idNumeroGerado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    xNumeroGerado = table.Column<int>(type: "int", nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_numerosGerados", x => x.idNumeroGerado);
                    table.ForeignKey(
                        name: "FK_tb_numerosGerados_tb_cliente_idCliente",
                        column: x => x.idCliente,
                        principalTable: "tb_cliente",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_numerosGerados_idCliente",
                table: "tb_numerosGerados",
                column: "idCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_numerosGerados");

            migrationBuilder.DropTable(
                name: "tb_cliente");
        }
    }
}
