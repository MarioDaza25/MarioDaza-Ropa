using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class GeneroRepository : GenericRepository<Genero>, IGenero
{
    public readonly DbAppContext _context;

    public GeneroRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
