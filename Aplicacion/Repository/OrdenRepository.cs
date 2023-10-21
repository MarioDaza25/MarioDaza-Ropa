using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class OrdenRepository : GenericRepository<Orden>, IOrden
{
    public readonly DbAppContext _context;

    public OrdenRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }

    //Listar las prendas de una orden de producción cuyo estado sea en producción. El usuario debe ingresar el número de orden de producción.
    public async Task<IEnumerable<Orden>> PrendasPorOrdenYEstado(int numeroOrden, string estado)
    {
        return await _context.Ordenes
        .Where(m => m.Id == numeroOrden && m.Estado.TipoEstado.Descripcion == estado)
        .Include(d => d.DetalleOrdenes).ThenInclude(dor => dor.Prenda)
        .ToListAsync();
    }
}
