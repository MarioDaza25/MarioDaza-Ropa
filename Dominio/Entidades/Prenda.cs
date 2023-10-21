namespace Dominio.Entidades;

public class Prenda : BaseEntity
{
    public int IdPrenda { get; set; }
    public string Nombre { get; set; }
    public decimal ValorUnitCop { get; set; }
    public decimal ValorUnitUsd { get; set; }
    public int Id_Estado { get; set; }
    public Estado Estado { get; set; }
    public int Id_TipoProteccion { get; set; }
    public TipoProteccion TipoProteccion { get; set; }
    public int Id_Genero { get; set; }
    public Genero Genero { get; set; }

    public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    public ICollection<Insumo> Insumos { get; set; } = new HashSet<Insumo>();
    public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }
}
