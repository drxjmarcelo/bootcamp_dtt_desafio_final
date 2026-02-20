using Microsoft.EntityFrameworkCore;
using EquipApi.Models;

namespace EquipApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Equipamento> Equipamentos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.ToTable("Equipamentos", "public");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .IsRequired();

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .IsRequired();

                entity.Property(e => e.Modelo)
                    .HasColumnName("modelo")
                    .IsRequired();

                entity.Property(e => e.Horimetro)
                    .HasColumnName("horimetro")
                    .IsRequired();

                entity.Property(e => e.StatusOperacional)
                    .HasColumnName("statusoperacional")
                    .IsRequired();

                entity.Property(e => e.DataAquisicao)
                    .HasColumnName("dataaquisicao")
                    .IsRequired();

                entity.Property(e => e.LocalizacaoAtual)
                    .HasColumnName("localizacaoatual")
                    .IsRequired();

                entity.HasIndex(e => e.Codigo)
                    .IsUnique()
                    .HasDatabaseName("ux_equipamentos_codigo");
            });
        }
    }
}