using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
{
    public void Configure(EntityTypeBuilder<Insumo> builder)
    {
            
        builder.ToTable("Insumo");

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasIndex(e => e.Nombre)
        .IsUnique();

        builder.Property(p => p.ValorUnitario)
        .IsRequired();
        
        builder.Property(p => p.StockMin)
        .IsRequired();
        
        builder.Property(p => p.StockMax)
        .IsRequired();

        builder.HasMany(p => p.Proveedores)
        .WithMany(p => p.Insumos)
        .UsingEntity<InsumoProveedor>(
            j => j
                .HasOne(t => t.Proveedor)
                .WithMany(t => t.InsumoProveedores)
                .HasForeignKey(t => t.Id_Proveedor),
            j => j
                .HasOne(p => p.Insumo)
                .WithMany(p => p.InsumoProveedores)
                .HasForeignKey(p => p.Id_Insumo),
            j =>
            {
                j.HasKey(t => new {t.Id_Proveedor, t.Id_Insumo});
            }
        );
   }
}