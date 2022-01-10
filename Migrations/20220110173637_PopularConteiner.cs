using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estaleiro.Migrations
{
    public partial class PopularConteiner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Conteiners(Cliente,NumeroConteiner,TipoConteiner,StatusConteiner,CategoriaConteiner) VALUES('Mauá Porto','CAJU3212128',20,1,1)");
            migrationBuilder.Sql("INSERT INTO Conteiners(Cliente,NumeroConteiner,TipoConteiner,StatusConteiner,CategoriaConteiner) VALUES('Marinha Brasil','CAJU5513301',40,2,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Conteiners");
            migrationBuilder.Sql("DELETE FROM Movimentacoes");
        }
    }
}
