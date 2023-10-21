using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
{
    public void Configure(EntityTypeBuilder<Cargo> builder)
    {
        builder.ToTable("Cargo");

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(20);

         builder.Property(p => p.SueldoBase)
        .IsRequired();
   }
}