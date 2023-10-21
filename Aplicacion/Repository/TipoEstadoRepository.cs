using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class TipoEstadoRepository : GenericRepository<TipoEstado>, ITipoEstado
{
    public readonly DbAppContext _context;

    public TipoEstadoRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
