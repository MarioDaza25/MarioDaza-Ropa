using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleado
{
    public readonly DbAppContext _context;

    public EmpleadoRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }

    //Listar las ventas realizadas por un empleado especifico. El usuario debe ingresar el Id del empleado y mostrar la siguiente información.
    //1. Id Empleado
    //2. Nombre del empleado
    //3. Fecturas : Nro Factura, fecha y total de la factura.
    public async Task<IEnumerable<Empleado>> NombreMetodo(string precio)
    {
        return await _context.Empleados
            .Where(m => m.IdEmpleado == precio)
            .Include(e => e.Ventas).ThenInclude(v => v.DetalleVentas)
        .ToListAsync();
    }
}
