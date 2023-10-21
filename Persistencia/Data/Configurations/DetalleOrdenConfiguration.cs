using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
{
    public void Configure(EntityTypeBuilder<DetalleOrden> builder)
    {
        builder.ToTable("DetalleOrden");

       
        builder.HasOne(p => p.Orden)
        .WithMany(p => p.DetalleOrdenes)
        .HasForeignKey(p => p.Id_Orden);

        builder.HasOne(p => p.Prenda)
        .WithMany(p => p.DetalleOrdenes)
        .HasForeignKey(p => p.Id_Prenda);

         builder.Property(p => p.CantidadProducir)
        .IsRequired();

        builder.HasOne(p => p.Color)
        .WithMany(p => p.DetalleOrdenes)
        .HasForeignKey(p => p.Id_Color);

         builder.Property(p => p.CantidadProducida)
        .IsRequired();

        builder.HasOne(p => p.Estado)
        .WithMany(p => p.DetalleOrdenes)
        .HasForeignKey(p => p.Id_Estado);

   }
}