using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersona
{
    public readonly DbAppContext _context;

    public TipoPersonaRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
