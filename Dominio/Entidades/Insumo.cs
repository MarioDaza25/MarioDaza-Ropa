namespace Dominio.Entidades;

public class Insumo : BaseEntity
{
    public string Nombre { get; set; }
    public decimal ValorUnitario { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }

    public ICollection<Prenda> Prendas { get; set; } = new HashSet<Prenda>();
    public ICollection<InsumoPrenda> InsumoPrendas { get; set; } 

    public ICollection<Proveedor> Proveedores { get; set; } = new HashSet<Proveedor>();
    public ICollection<InsumoProveedor> InsumoProveedores { get; set; } 
}
