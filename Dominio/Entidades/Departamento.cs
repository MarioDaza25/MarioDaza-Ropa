namespace Dominio.Entidades;

public class Departamento : BaseEntity
{
    public string Nombre { get; set; }
    public int Id_Pais { get; set; }
    public Pais Pais { get; set; }
}
