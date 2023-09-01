using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LDatos.Migrations
{
    public partial class SegundoIno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DuenoId",
                table: "Perros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(25)", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perros_DuenoId",
                table: "Perros",
                column: "DuenoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perros_Personas_DuenoId",
                table: "Perros",
                column: "DuenoId",
                principalTable: "Personas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perros_Personas_DuenoId",
                table: "Perros");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Perros_DuenoId",
                table: "Perros");

            migrationBuilder.DropColumn(
                name: "DuenoId",
                table: "Perros");
        }
    }
}
