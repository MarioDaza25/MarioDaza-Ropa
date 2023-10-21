using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
{
    public void Configure(EntityTypeBuilder<Prenda> builder)
    {
        builder.ToTable("Prenda");

        builder.Property(p => p.IdPrenda)
        .IsRequired()
        .HasMaxLength(20);

        builder.HasIndex(e => e.IdPrenda)
        .IsUnique();


        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.ValorUnitCop)
        .IsRequired();

        builder.Property(p => p.ValorUnitUsd)
        .IsRequired();

        builder.HasOne(p => p.Estado)
        .WithMany(p => p.Prendas)
        .HasForeignKey(p => p.Id_Estado);

        builder.HasOne(p => p.TipoProteccion)
        .WithMany(p => p.Prendas)
        .HasForeignKey(p => p.Id_TipoProteccion);

         builder.HasOne(p => p.Genero)
        .WithMany(p => p.Prendas)
        .HasForeignKey(p => p.Id_Genero);

        builder.HasMany(p => p.Insumos)
        .WithMany(p => p.Prendas)
        .UsingEntity<InsumoPrenda>(
            j => j
                .HasOne(t => t.Insumo)
                .WithMany(t => t.InsumoPrendas)
                .HasForeignKey(t => t.Id_Insumo),
            j => j
                .HasOne(p => p.Prenda)
                .WithMany(p => p.InsumoPrendas)
                .HasForeignKey(p => p.Id_Prenda),
            j =>
            {
                j.HasKey(t => new {t.Id_Insumo, t.Id_Prenda});
            }
        );
   }
}