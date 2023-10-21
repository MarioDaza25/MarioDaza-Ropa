using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.ToTable("Empresa");

        builder.Property(p => p.Nit)
        .IsRequired()
        .HasMaxLength(15);

        builder.HasIndex(e => e.Nit)
        .IsUnique();


        builder.Property(p => p.RazonSocial)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.RepresentanteLegal)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.FechaCreacion)
        .IsRequired()
        .HasColumnType("Date");

        builder.HasOne(p => p.Municipio)
        .WithMany(p => p.Empresas)
        .HasForeignKey(p => p.Id_Municipio);

   }
}