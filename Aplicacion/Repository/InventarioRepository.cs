using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class InventarioRepository : GenericRepository<Inventario>, IInventario 
{   
    public readonly DbAppContext _context;

    public InventarioRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
