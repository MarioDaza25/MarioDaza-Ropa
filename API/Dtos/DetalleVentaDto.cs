namespace API.Dtos;

public class DetalleVentaDto
{
    public int Id { get; set; }
    public int Id_Venta { get; set; }
    public int Id_Producto { get; set; }
    public int Id_Talla { get; set; }
    public int Cantidad { get; set; }
    public decimal ValorUnitario { get; set; }
}
