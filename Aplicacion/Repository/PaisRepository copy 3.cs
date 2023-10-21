using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class PaisRepository : GenericRepository<Pais>, IPais
{
    public readonly DbAppContext _context;

    public PaisRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
