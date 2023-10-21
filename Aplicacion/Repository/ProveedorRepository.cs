using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class ProveedorRepository : GenericRepository<Proveedor>, IProveedor
{
    public readonly DbAppContext _context;

    public ProveedorRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
