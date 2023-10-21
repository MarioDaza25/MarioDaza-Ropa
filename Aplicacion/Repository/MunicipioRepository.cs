using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class MunicipioRepository : GenericRepository<Municipio>, IMunicipio
{
    public readonly DbAppContext _context;

    public MunicipioRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
