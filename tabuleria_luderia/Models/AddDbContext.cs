

using Microsoft.EntityFrameworkCore;

namespace tabuleria_luderia.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Loja> Lojas { get; set; }

    }
}
