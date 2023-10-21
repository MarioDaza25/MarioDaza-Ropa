using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
{
    public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
    {
        builder.ToTable("InsumoPrenda");

        builder.Property(p => p.Cantidad)
        .IsRequired();
   }
}