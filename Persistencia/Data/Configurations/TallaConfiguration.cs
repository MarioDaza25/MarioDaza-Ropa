using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TallaConfiguration : IEntityTypeConfiguration<Talla>
{
    public void Configure(EntityTypeBuilder<Talla> builder)
    {
        builder.ToTable("Talla");

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(5);

        builder.HasIndex(e => e.Descripcion)
        .IsUnique();


        builder.HasMany(p => p.Inventarios)
        .WithMany(p => p.Tallas)
        .UsingEntity<InventarioTalla>(
            j => j
                .HasOne(t => t.Inventario)
                .WithMany(t => t.InventarioTallas)
                .HasForeignKey(t => t.Id_Inv),
            j => j
                .HasOne(p => p.Talla)
                .WithMany(p => p.InventarioTallas)
                .HasForeignKey(p => p.Id_Talla),
            j =>
            {
                j.HasKey(t => new {t.Id_Inv, t.Id_Talla});
            }
        );
   }
}