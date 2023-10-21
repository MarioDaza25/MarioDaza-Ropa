using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class DetalleOrdenRepository : GenericRepository<DetalleOrden>, IDetalleOrden
{
    public readonly DbAppContext _context;

    public DetalleOrdenRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
