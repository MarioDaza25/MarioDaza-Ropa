using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
{
    public void Configure(EntityTypeBuilder<Estado> builder)
    {
        builder.ToTable("Estado");

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(20);

        builder.HasOne(p => p.TipoEstado)
        .WithMany(p => p.Estados)
        .HasForeignKey(p => p.Id_TipoEstado);
   }
}