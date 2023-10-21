namespace Dominio.Entidades;

public class Venta : BaseEntity
{
     public DateOnly Fecha { get; set; }
     public int Id_Empleado { get; set; }
     public Empleado Empleado { get; set; }
     public int Id_Cliente { get; set; }
     public Cliente Cliente { get; set; }
     public int Id_FormaPago { get; set; }
     public FormaPago FormaPago { get; set; }
     public ICollection<DetalleVenta> DetalleVentas { get; set; }
}
