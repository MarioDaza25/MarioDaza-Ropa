namespace Dominio.Entidades;

public class TipoPersona : BaseEntity
{
    public ICollection<Cliente> Clientes { get; set; }
}
