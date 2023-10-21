using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
{
    public void Configure(EntityTypeBuilder<DetalleVenta> builder)
    {
        builder.ToTable("DetalleVenta");

        builder.HasOne(p => p.Venta)
        .WithMany(p => p.DetalleVentas)
        .HasForeignKey(p => p.Id_Venta);

         builder.HasOne(p => p.Producto)
        .WithMany(p => p.DetalleVentas)
        .HasForeignKey(p => p.Id_Producto);

         builder.HasOne(p => p.Talla)
        .WithMany(p => p.DetalleVentas)
        .HasForeignKey(p => p.Id_Talla);

        builder.Property(p => p.Cantidad)
        .IsRequired();

         builder.Property(p => p.ValorUnitario)
        .IsRequired();
   }
}