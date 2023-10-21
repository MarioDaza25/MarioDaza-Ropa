using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TipoEstadoConfiguration : IEntityTypeConfiguration<TipoEstado>
{
    public void Configure(EntityTypeBuilder<TipoEstado> builder)
    {
        builder.ToTable("TipoEstado");

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(25);
   }
}