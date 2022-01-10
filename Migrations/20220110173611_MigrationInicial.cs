using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estaleiro.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conteiners",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumeroConteiner = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    TipoConteiner = table.Column<int>(type: "int", nullable: false),
                    StatusConteiner = table.Column<int>(type: "int", nullable: false),
                    CategoriaConteiner = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteiners", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conteiners");
        }
    }
}
