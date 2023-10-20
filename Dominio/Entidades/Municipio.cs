namespace Dominio.Entidades;

public class Municipio : BaseEntity
{
    public ICollection<Cliente> Clientes { get; set; }
}
