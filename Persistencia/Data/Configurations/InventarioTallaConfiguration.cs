using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
{
    public void Configure(EntityTypeBuilder<InventarioTalla> builder)
    {
        builder.ToTable("InventarioTalla");

        builder.Property(p => p.Cantidad)
        .IsRequired();
   }
}