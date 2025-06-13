using Microsoft.EntityFrameworkCore;
using Catholirism.Model;

namespace Catholirism.Data
{
    public class CatholirismContexto : DbContext
    {
        public CatholirismContexto()
        {
        }

        public CatholirismContexto(DbContextOptions<CatholirismContexto> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Reserva> Reservas { get; set; } = null!;
        public virtual DbSet<Destino> Destinos { get; set; } = null!;
        public virtual DbSet<Pacote_Turistico> Pacotes_Turisticos { get; set; } = null!;
        public virtual DbSet<PacoteDestino> PacoteDestinos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapeamento das tabelas com os novos nomes
            modelBuilder.Entity<Cliente>().ToTable("Clientela");
            modelBuilder.Entity<Reserva>().ToTable("Agendamentos");
            modelBuilder.Entity<Destino>().ToTable("Locais");
            modelBuilder.Entity<Pacote_Turistico>().ToTable("PacotesTurismo");
            modelBuilder.Entity<PacoteDestino>().ToTable("PacoteLocais");

            // Configuração da chave composta para PacoteDestino
            modelBuilder.Entity<PacoteDestino>()
                .HasKey(pd => new { pd.PacoteId, pd.DestinoId });

            // Relacionamento entre PacoteDestino e Pacote_Turistico
            modelBuilder.Entity<PacoteDestino>()
                .HasOne(pd => pd.Pacote)
                .WithMany(p => p.PacoteDestinos)
                .HasForeignKey(pd => pd.PacoteId);

            // Relacionamento entre PacoteDestino e Destino
            modelBuilder.Entity<PacoteDestino>()
                .HasOne(pd => pd.Destino)
                .WithMany(d => d.PacoteDestinos)
                .HasForeignKey(pd => pd.DestinoId);

            // Relacionamento entre Reserva e Cliente
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Cliente)
                .WithMany(c => c.Reservas)
                .HasForeignKey(r => r.ClienteId);

            // Relacionamento entre Reserva e Pacote_Turistico
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.PacoteTuristico)
                .WithMany()
                .HasForeignKey(r => r.PacoteId);
        }
    }
}