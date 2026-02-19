using Microsoft.EntityFrameworkCore;
using EquipApi.Models;

namespace EquipApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Equipamento> Equipamentos => Set<Equipamento>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Modelo)
                    .IsRequired();

                entity.Property(e => e.Horimetro)
                    .HasPrecision(10,2);
            });
        }
    }

}