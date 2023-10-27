using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.Modelsss;

namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Musica> musica { get; set; }
        public DbSet<Disco> disco { get; set; }
    }
}
