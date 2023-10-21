using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class PrendaRepository : GenericRepository<Prenda>, IPrenda
{
    public readonly DbAppContext _context;

    public PrendaRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }

    
}
