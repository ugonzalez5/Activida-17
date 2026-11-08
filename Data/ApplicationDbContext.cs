using Actividad17_EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Actividad17_EFCore.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Estudiante> Estudiantes => Set<Estudiante>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.ToTable("Estudiantes");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nombre).HasMaxLength(120).IsRequired();
            entity.Property(e => e.Correo).HasMaxLength(160).IsRequired();
            entity.HasIndex(e => e.Correo).IsUnique();
            entity.Property(e => e.Calificacion).HasPrecision(4, 2);
        });
    }
}
