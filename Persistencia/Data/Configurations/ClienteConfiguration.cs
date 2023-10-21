using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Cliente");

        builder.Property(p => p.IdCliente)
        .IsRequired()
        .HasMaxLength(15);

        builder.HasIndex(e => e.IdCliente)
        .IsUnique();


        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.FechaRegistro)
        .IsRequired()
        .HasColumnType("Date");

        builder.HasOne(p => p.TipoPersona)
        .WithMany(p => p.Clientes)
        .HasForeignKey(p => p.Id_TipoPersona);

        builder.HasOne(p => p.Municipio)
        .WithMany(p => p.Clientes)
        .HasForeignKey(p => p.Id_Municipio);
   }
}