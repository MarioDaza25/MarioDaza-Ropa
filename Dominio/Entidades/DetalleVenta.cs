namespace Dominio.Entidades;

public class DetalleVenta : BaseEntity
{
    public int Id_Venta { get; set; }
    public Venta Venta { get; set; }
    public int Id_Producto { get; set; }
    public Inventario Producto { get; set; }
    public int Id_Talla { get; set; }
    public Talla Talla { get; set; }
    public int Cantidad { get; set; }
    public decimal ValorUnitario { get; set; }
}
