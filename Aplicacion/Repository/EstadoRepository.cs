using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class EstadoRepository : GenericRepository<Estado>, IEstado
{
    public readonly DbAppContext _context;

    public EstadoRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
