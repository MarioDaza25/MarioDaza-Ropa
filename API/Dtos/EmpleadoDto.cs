namespace API.Dtos;

public class EmpleadoDto
{
    public int Id { get; set; }
    public int IdEmpleado { get; set; }
    public string Nombre { get; set; }
    public int Id_Cargo { get; set; }
    public DateOnly FechaIngreso { get; set; }
    public int Id_Municipio { get; set; }
}
