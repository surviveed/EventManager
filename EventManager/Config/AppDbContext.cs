using EventManager.Entities;
using System.Data.Entity;

namespace EventManager.Config
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=EventManagerDbContext")
        {
        }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Uf> Ufs { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<TipoEvento> TiposEvento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações adicionais para o mapeamento das entidades

            modelBuilder.Entity<Pais>()
                .ToTable("public.pais")
                .HasKey(p => p.Id);

            modelBuilder.Entity<Uf>()
                .ToTable("public.uf")
                .HasKey(u => u.Id);

            modelBuilder.Entity<Uf>()
                .HasRequired(u => u.Pais)
                .WithMany()
                .HasForeignKey(u => u.PaisId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cidade>()
                .ToTable("public.cidade")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Cidade>()
                .HasRequired(c => c.Uf)
                .WithMany() 
                .HasForeignKey(c => c.UfId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Local>()
                .ToTable("public.local")
                .HasKey(l => l.Id);

            modelBuilder.Entity<Local>()
                .HasRequired(l => l.Cidade)
                .WithMany()
                .HasForeignKey(l => l.CidadeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoEvento>()
                .ToTable("public.tipo_evento")
                .HasKey(p => p.Id);
        }
    }
}
