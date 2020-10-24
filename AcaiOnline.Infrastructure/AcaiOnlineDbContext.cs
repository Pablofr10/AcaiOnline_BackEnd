using AcaiOnline.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace AcaiOnline.Infrastructure
{
    public class AcaiOnlineDbContext : DbContext
    {
        public AcaiOnlineDbContext(DbContextOptions<AcaiOnlineDbContext> options) : base (options)
        { }
        
        public DbSet<Produto> Produto { get; set; } 
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Adicional> Adicionais { get; set; }
        public DbSet<Fidelidade> Fidelidade { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Acompanhamento> Acompanhamento { get; set; }
        public DbSet<PedidoProduto> PedidoProduto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoriaProduto>()                
                .HasIndex(cp => cp.RelId).IsUnique();

            modelBuilder.Entity<PedidoProduto>()
                .HasIndex(cp => cp.RelId).IsUnique();

            modelBuilder.Entity<Acompanhamento>()
                .HasKey(cp => cp.Id);
            
            modelBuilder.Entity<Cliente>()
                .HasOne(cl => cl.Fidelidade)
                .WithOne(cl => cl.Cliente)
                .HasForeignKey<Fidelidade>(f => f.ClienteId);

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId);

            modelBuilder.Entity<Adicional>()
                .HasOne(a => a.Pedidos)
                .WithMany(a => a.Adicionais)
                .HasForeignKey(p => p.PedidoId);

            modelBuilder.Entity<Pagamento>()
                .HasOne(a => a.Pedidos)
                .WithMany(a => a.Pagamento)
                .HasForeignKey(p => p.PedidoId);

            modelBuilder.Entity<Fidelidade>().Ignore(t => t.Cliente);
            modelBuilder.Entity<Pagamento>().Ignore(t => t.Pedidos);
            modelBuilder.Entity<Adicional>().Ignore(p => p.Pedidos);
        }
    }
}
