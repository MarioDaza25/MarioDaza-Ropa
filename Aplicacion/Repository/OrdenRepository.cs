using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class OrdenRepository : GenericRepository<Orden>, IOrden
{
    public readonly DbAppContext _context;

    public OrdenRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
