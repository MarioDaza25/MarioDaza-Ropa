namespace Dominio.Entidades;

public class Pais : BaseEntity
{
    public ICollection<Departamento> Departamentos { get; set; }
}
