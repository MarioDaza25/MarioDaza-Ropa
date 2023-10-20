namespace Dominio.Entidades;

public class DetalleOrden : BaseEntity
{
    public int Id_Orden { get; set; }
    public Orden Orden { get; set; }
    public int Id_Prenda { get; set; }
    public Prenda Prenda { get; set; }
    public int CantidadProducir { get; set; }
    public int Id_Color { get; set; }
    public Color Color { get; set; }
    public int CantidadProducida { get; set; }
    public int Id_Estado { get; set; }
    public Estado Estado { get; set; }

    
}
