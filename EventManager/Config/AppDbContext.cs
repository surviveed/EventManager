using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Config
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=EventManagerDbContext")
        {
        }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Uf> Ufs { get; set; }

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
        }
    }
}
