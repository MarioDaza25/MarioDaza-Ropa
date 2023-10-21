using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class TipoProteccionRepository : GenericRepository<TipoProteccion>, ITipoProteccion
{
    public readonly DbAppContext _context;

    public TipoProteccionRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }

    //Listar las prendas agrupadas por el tipo de protección.
    public async Task<IEnumerable<TipoProteccion>> PrendasPortipoProteccion()
    {
        return await _context.TipoProtecciones
            .Include(tp => tp.Prendas).Where(tp => tp.Prendas.Any())
            .ToListAsync();
    }
}
