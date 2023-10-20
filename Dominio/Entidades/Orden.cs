namespace Dominio.Entidades;

public class Orden
{
    public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
}
