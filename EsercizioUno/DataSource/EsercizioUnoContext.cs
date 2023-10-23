using EsercizioUno.Entities;
using Microsoft.EntityFrameworkCore;

namespace EsercizioUno.DataSource
{
    public class EsercizioUnoContext : DbContext
    {
        public EsercizioUnoContext()
        {
        }
        public EsercizioUnoContext(DbContextOptions<EsercizioUnoContext> options) : base(options)
        {
        }

        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Categoria> Categorie { get; set; }
    }
}
