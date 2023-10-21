using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class VentaRepository : GenericRepository<Venta>, IVenta
{
    public readonly DbAppContext _context;

    public VentaRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
