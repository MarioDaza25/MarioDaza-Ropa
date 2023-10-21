using Dominio.Entidades;

namespace Dominio.Interfaces;

public interface IProveedor : IGenericRepository<Proveedor>
{
    Task<IEnumerable<Proveedor>> ProveedoresPorTipoPersona(string tipopersona);
    Task<IEnumerable<Proveedor>> InsumoPorProveedor(string nit);
}
