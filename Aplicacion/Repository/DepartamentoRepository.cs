using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
{
    public readonly DbAppContext _context;

    public DepartamentoRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
