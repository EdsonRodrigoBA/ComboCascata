using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoArtigos.Migrations
{
    public partial class Migration_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    id_estado = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    UF = table.Column<string>(type: "CHAR(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.id_estado);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id_Cidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_estado = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    UF = table.Column<string>(type: "VARCHAR(2)", nullable: false),
                    Codigo_Ibge = table.Column<int>(type: "int", nullable: false),
                    Capital = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id_Cidade);
                    table.ForeignKey(
                        name: "FK_Cidades_Estados_Id_estado",
                        column: x => x.Id_estado,
                        principalTable: "Estados",
                        principalColumn: "id_estado");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_Id_estado",
                table: "Cidades",
                column: "Id_estado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
