using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class ColorRepository : GenericRepository<Color>, IColor
{
    public readonly DbAppContext _context;

    public ColorRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
