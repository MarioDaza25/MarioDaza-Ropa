using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
{
    public void Configure(EntityTypeBuilder<Municipio> builder)
    {
        builder.ToTable("Municipio");

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(20);

        builder.HasOne(p => p.Departamento)
        .WithMany(p => p.Municipios)
        .HasForeignKey(p => p.Id_Dep);

   }
}