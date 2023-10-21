using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class EmpresaRepository : GenericRepository<Empresa>, IEmpresa
{
    public readonly DbAppContext _context;

    public EmpresaRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
