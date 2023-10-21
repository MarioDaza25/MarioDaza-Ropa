using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class TipoProteccionRepository : GenericRepository<TipoProteccion>, ITipoProteccion
{
    public readonly DbAppContext _context;

    public TipoProteccionRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
