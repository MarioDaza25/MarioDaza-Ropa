namespace Dominio.Entidades;

public class Cliente : BaseEntity
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public int Id_TipoPersona { get; set; }
     public TipoPersona TipoPersona { get; set; }
    public DateOnly FechaRegistro { get; set; }
    public int Id_Municipio { get; set; }
    public Municipio Municipio { get; set; }
}
