using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class ClienteRepository : GenericRepository<Cliente>, ICliente
{
    public readonly DbAppContext _context;

    public ClienteRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
