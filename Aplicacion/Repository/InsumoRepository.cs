using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class InsumoRepository : GenericRepository<Insumo>, IInsumo
{
    public readonly DbAppContext _context;

    public InsumoRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
