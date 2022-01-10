using Estaleiro.Models;
using Microsoft.EntityFrameworkCore;

namespace Estaleiro.Data
{
    public class EstaleiroContext : DbContext
    {
        public EstaleiroContext(DbContextOptions<EstaleiroContext>options) : base (options)
        {

        }
        public DbSet<Conteiner> Conteiners { get; set; }

    }
}
