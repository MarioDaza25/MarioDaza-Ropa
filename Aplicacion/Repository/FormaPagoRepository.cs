using Dominio.Entidades;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class FormaPagoRepository : GenericRepository<FormaPago>, IFormaPago
{
    public readonly DbAppContext _context;

    public FormaPagoRepository(DbAppContext context) : base(context)
    {
        _context = context;
    }
}
