using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TipoProteccionConfiguration : IEntityTypeConfiguration<TipoProteccion>
{
    public void Configure(EntityTypeBuilder<TipoProteccion> builder)
    {
        builder.ToTable("TipoProteccion");

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(50);
   }
}