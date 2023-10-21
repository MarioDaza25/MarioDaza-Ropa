using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleado
{
    public readonly DbAppContext _context;

    public EmpleadoRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
