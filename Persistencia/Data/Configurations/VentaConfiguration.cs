using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class VentaConfiguration : IEntityTypeConfiguration<Venta>
{
    public void Configure(EntityTypeBuilder<Venta> builder)
    {
        builder.ToTable("Venta");

        builder.Property(p => p.Fecha)
        .IsRequired()
        .HasColumnType("Date");

        builder.HasOne(p => p.Empleado)
        .WithMany(p => p.Ventas)
        .HasForeignKey(p => p.Id_Empleado);

        builder.HasOne(p => p.Cliente)
        .WithMany(p => p.Ventas)
        .HasForeignKey(p => p.Id_Cliente);

        builder.HasOne(p => p.FormaPago)
        .WithMany(p => p.Ventas)
        .HasForeignKey(p => p.Id_FormaPago);

   }
}