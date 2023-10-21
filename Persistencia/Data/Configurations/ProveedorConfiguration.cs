using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
{
    public void Configure(EntityTypeBuilder<Proveedor> builder)
    {
        builder.ToTable("Proveedor");

        builder.Property(p => p.NitProveedor)
        .IsRequired()
        .HasMaxLength(15);

        builder.HasIndex(e => e.NitProveedor)
        .IsUnique();

         builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(25);

        builder.HasOne(p => p.TipoPersona)
        .WithMany(p => p.Proveedores)
        .HasForeignKey(p => p.Id_TipoPersona);

        builder.HasOne(p => p.Municipio)
        .WithMany(p => p.Proveedores)
        .HasForeignKey(p => p.Id_Municipio);
   }
}