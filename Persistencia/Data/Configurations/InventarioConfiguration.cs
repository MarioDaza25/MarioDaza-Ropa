using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("Inventario");

        builder.Property(p => p.CodInv)
        .IsRequired()
        .HasMaxLength(15);

        builder.HasIndex(e => e.CodInv)
        .IsUnique();

        builder.Property(p => p.Id_Prenda)
        .IsRequired();
        
        builder.Property(p => p.ValorVtaCop)
        .IsRequired();
        
        builder.Property(p => p.ValorVtaUsd)
        .IsRequired();
   }
}