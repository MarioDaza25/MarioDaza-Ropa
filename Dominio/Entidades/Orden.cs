namespace Dominio.Entidades;

public class Orden : BaseEntity
{
    public DateOnly Fecha { get; set; }
    public int Id_Empleado { get; set; }
    public Empleado Empleado { get; set; }
    public int Id_Cliente { get; set; }
    public Cliente Cliente { get; set; }
    public int Id_Estado { get; set; }
    public Estado Estado { get; set; }
   
    public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
}
