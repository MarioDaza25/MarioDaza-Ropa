namespace API.Dtos;

public class OrdenDto
{
    public int Id { get; set; }
    public DateOnly Fecha { get; set; }
    public int Id_Empleado { get; set; }
    public int Id_Cliente { get; set; }
    public int Id_Estado { get; set; }
    public ICollection<DetalleConPrendaDto> DetalleOrdenes { get; set; }
}
