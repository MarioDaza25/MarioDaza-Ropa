using Dominio.Entidades;

namespace Dominio.Interfaces;

public interface IOrden : IGenericRepository<Orden>
{
    Task<IEnumerable<Orden>> PrendasPorOrdenYEstado(int numeroOrden, string estado);
}
