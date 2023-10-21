using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("Empleado");

        builder.Property(p => p.IdEmpleado)
        .IsRequired()
        .HasMaxLength(15);

        builder.HasIndex(e => e.IdEmpleado)
        .IsUnique();


        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(30);

        builder.Property(p => p.FechaIngreso)
        .IsRequired()
        .HasColumnType("Date");

        builder.HasOne(p => p.Cargo)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.Id_Cargo);

        builder.HasOne(p => p.Municipio)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.Id_Municipio);
   }
}