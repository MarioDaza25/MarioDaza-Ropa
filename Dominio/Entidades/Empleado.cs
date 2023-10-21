namespace Dominio.Entidades;

public class Empleado : BaseEntity
{
    public string IdEmpleado { get; set; }
    public string Nombre { get; set; }
    public int Id_Cargo { get; set; }
    public Cargo Cargo { get; set; }
    public DateOnly FechaIngreso { get; set; }
    public int Id_Municipio { get; set; }
    public Municipio Municipio { get; set; }
    
    public ICollection<Orden> Ordenes { get; set; }
    public ICollection<Venta> Ventas { get; set; }
}
