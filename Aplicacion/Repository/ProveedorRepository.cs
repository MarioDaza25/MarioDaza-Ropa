using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class ProveedorRepository : GenericRepository<Proveedor>, IProveedor
{
    public readonly DbAppContext _context;

    public ProveedorRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }

    //Listar los proveedores que sean persona natural.
    public async Task<IEnumerable<Proveedor>> ProveedoresPorTipoPersona(string tipopersona)
    {
        return await _context.Proveedores
            .Where(m => m.TipoPersona.Nombre == tipopersona)
            .ToListAsync();
    }

    //Listar los insumos que son vendidos por un determinado proveedor. El usuario debe ingresar el Nit de proveedor.
    public async Task<IEnumerable<Proveedor>> InsumoPorProveedor(string nit)
    {
        return await _context.Proveedores
            .Where(m => m.NitProveedor == nit)
            .Include(p => p.InsumoProveedores).ThenInclude(ip => ip.Insumo)
            .ToListAsync();
    }

   
}
