using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class DetalleVentaRepository : GenericRepository<DetalleVenta>, IDetalleVenta
{
    public readonly DbAppContext _context;

    public DetalleVentaRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
