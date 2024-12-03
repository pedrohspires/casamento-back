using Microsoft.EntityFrameworkCore;

namespace Testes
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        //public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações de entidades
            //modelBuilder.Entity<Produto>().HasKey(u => u.Id);
        }
    }
}
