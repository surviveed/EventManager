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
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Pessoa> Pessoas{ get; set; }
        public DbSet<Papel> Papeis{ get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TipoEvento
            modelBuilder.Entity<TipoEvento>()
                .ToTable("public.tipo_evento")
                .HasKey(te => te.Id);

            modelBuilder.Entity<TipoEvento>()
                .HasMany(te => te.Eventos)
                .WithRequired(e => e.TipoEvento)
                .HasForeignKey(e => e.TipoEventoId);

            // Evento
            modelBuilder.Entity<Evento>()
                .ToTable("public.evento")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Evento>()
                .HasMany(e => e.Sessoes)
                .WithRequired(s => s.Evento)
                .HasForeignKey(s => s.EventoId);

            modelBuilder.Entity<Evento>()
                .HasMany(e => e.Organizadores)
                .WithMany(p => p.EventosOrganizados)
                .Map(m =>
                {
                    m.ToTable("public.evento_organizadores");
                    m.MapLeftKey("evento_id");
                    m.MapRightKey("pessoa_id");
                });

            // Pais
            modelBuilder.Entity<Pais>()
                .ToTable("public.pais")
                .HasKey(p => p.Id);

            modelBuilder.Entity<Pais>()
                .HasMany(p => p.Ufs)
                .WithRequired(u => u.Pais)
                .HasForeignKey(u => u.PaisId);

            // Uf
            modelBuilder.Entity<Uf>()
                .ToTable("public.uf")
                .HasKey(u => u.Id);

            modelBuilder.Entity<Uf>()
                .HasMany(u => u.Cidades)
                .WithRequired(c => c.Uf)
                .HasForeignKey(c => c.UfId);

            // Cidade
            modelBuilder.Entity<Cidade>()
                .ToTable("public.cidade")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Cidade>()
                .HasMany(c => c.Locais)
                .WithRequired(l => l.Cidade)
                .HasForeignKey(l => l.CidadeId);

            // Local
            modelBuilder.Entity<Local>()
                .ToTable("public.local")
                .HasKey(l => l.Id);

            modelBuilder.Entity<Local>()
                .HasMany(l => l.Sessoes)
                .WithRequired(s => s.Local)
                .HasForeignKey(s => s.LocalId);

            // Sessao
            modelBuilder.Entity<Sessao>()
                .ToTable("public.sessao")
                .HasKey(s => s.Id);

            modelBuilder.Entity<Sessao>()
                .HasMany(s => s.Avaliacoes)
                .WithRequired(a => a.Sessao)
                .HasForeignKey(a => a.SessaoId);

            // Pessoa
            modelBuilder.Entity<Pessoa>()
                .ToTable("public.pessoa")
                .HasKey(p => p.Id);

            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.Avaliacoes)
                .WithRequired(a => a.Pessoa)
                .HasForeignKey(a => a.PessoaId);

            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.Sessoes)
                .WithMany(s => s.Integrantes)
                .Map(m =>
                {
                    m.ToTable("public.sessao_integrantes");
                    m.MapLeftKey("pessoa_id");
                    m.MapRightKey("sessao_id");
                });

            // Avaliacao
            modelBuilder.Entity<Avaliacao>()
                .ToTable("public.avaliacao")
                .HasKey(a => a.Id);

            // Papel
            modelBuilder.Entity<Papel>()
                .ToTable("public.papel")
                .HasKey(p => p.Id);

            // Usuario
            modelBuilder.Entity<Usuario>()
                .ToTable("public.usuario")
                .HasKey(u => u.Id);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Papeis)
                .WithMany(p => p.Usuarios)
                .Map(m =>
                {
                    m.ToTable("public.usuario_papel");
                    m.MapLeftKey("usuario_id");
                    m.MapRightKey("papel_id");
                });
        }
    }
}
