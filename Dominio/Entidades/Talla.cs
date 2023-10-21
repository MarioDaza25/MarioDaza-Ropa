namespace Dominio.Entidades;

public class Talla : BaseEntity
{
     public string Descripcion { get; set; }
     
     public ICollection<DetalleVenta> DetalleVentas { get; set; }
     public ICollection<Inventario> Inventarios { get; set; } = new HashSet<Inventario>();
     public ICollection<InventarioTalla> InventarioTallas { get; set; }
}
