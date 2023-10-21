namespace Dominio.Entidades;

public class Inventario : BaseEntity
{
     public int CodInv { get; set; }
     public int Id_Prenda { get; set; }
     public Prenda Prenda { get; set; }
     public decimal ValorVtaCop { get; set; }
     public decimal ValorVtaUsd { get; set; }
     
     public ICollection<DetalleVenta> DetalleVentas { get; set; }
     public ICollection<Talla> Tallas { get; set; } = new HashSet<Talla>();
     public ICollection<InventarioTalla> InventarioTallas { get; set; }
}
