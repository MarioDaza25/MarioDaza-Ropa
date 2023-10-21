using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class TallaRepository : GenericRepository<Talla>, ITalla
{
    public readonly DbAppContext _context;

    public TallaRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
