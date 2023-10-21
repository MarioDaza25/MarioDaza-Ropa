namespace API.Dtos;

public class VentaDto
{
    public int Id { get; set; }
    public DateOnly Fecha { get; set; }
     public int Id_Empleado { get; set; }
     public int Id_Cliente { get; set; }
     public int Id_FormaPago { get; set; }
}
