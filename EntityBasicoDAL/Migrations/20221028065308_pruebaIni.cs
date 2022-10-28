using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityBasicoDAL.Migrations
{
    public partial class pruebaIni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_empleado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nivel_accesos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nivel_acceso = table.Column<string>(type: "text", nullable: false),
                    desc_acceso = table.Column<string>(type: "text", nullable: false),
                    empleadoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nivel_accesos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nivel_accesos_empleados_empleadoId",
                        column: x => x.empleadoId,
                        principalTable: "empleados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_nivel_accesos_empleadoId",
                table: "nivel_accesos",
                column: "empleadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nivel_accesos");

            migrationBuilder.DropTable(
                name: "empleados");
        }
    }
}
