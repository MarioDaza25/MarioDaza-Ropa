using Dominio.Entidades;

namespace Dominio.Interfaces;

public interface ITipoProteccion : IGenericRepository<TipoProteccion>
{
    Task<IEnumerable<TipoProteccion>> PrendasPortipoProteccion();
}
