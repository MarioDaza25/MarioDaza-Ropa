using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class CargoRepository : GenericRepository<Cargo>, ICargo
{
    public readonly DbAppContext _context;

    public CargoRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
