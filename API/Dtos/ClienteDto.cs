namespace API.Dtos;

public class ClienteDto
{
    public int Id { get; set; }
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public int Id_TipoPersona { get; set; }
    public DateOnly FechaRegistro { get; set; }
    public int Id_Municipio { get; set; }
    
}
