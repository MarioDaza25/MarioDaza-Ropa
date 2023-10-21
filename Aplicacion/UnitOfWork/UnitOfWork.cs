using System.Runtime.CompilerServices;
using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DbAppContext _context;
    public UnitOfWork(DbAppContext context)
    {
        _context = context;
    }
    PaisRepository _pais; 
    InsumoRepository _insumo ;
    InventarioRepository _inventario ;
    TallaRepository _talla ;
    DetalleVentaRepository _detalleVenta ;
    DepartamentoRepository _departamento ;
    PrendaRepository _prenda ;
    ProveedorRepository _proveedor ;
    EmpleadoRepository _empleado ;
    CargoRepository _cargo;
    ClienteRepository _cliente ;
    VentaRepository _venta ;
    MunicipioRepository _municipio ;
    EmpresaRepository _empresa ;
    TipoProteccionRepository _tipoProteccion ;
    TipoPersonaRepository _tipoPersona ;
    GeneroRepository _genero ;
    EstadoRepository _estado ;
    TipoEstadoRepository _tipoEstado ;
    FormaPagoRepository _formaPago ;
    OrdenRepository _orden ;
    ColorRepository _color ;
    DetalleOrdenRepository _detalleOrden ;
    UsuarioRepository _usuario;
    RolRepository _rol;

    public IUsuario Usuarios
    {
        get
        {
            if (_usuario is not null)
            {
                return _usuario;
            }
            return _usuario = new UsuarioRepository(_context);
        }
    }
    public IRol Roles
    {
        get
        {
            if (_rol is not null)
            {
                return _rol;
            }
            return _rol = new RolRepository(_context);
        }
    }

    public IPais Paises 
    {
        get
        {
            if( _pais is not null)
            {
                return _pais; 
            }
            return _pais  = new PaisRepository(_context);
        }
    }

    public IInsumo Insumos 
    {
        get
        {
            if(_insumo is not null)
            {
                return _insumo; 
            }
            return _insumo  = new InsumoRepository(_context);
        }
    }

    public IInventario Inventarios 
    {
        get
        {
            if( _inventario is not null)
            {
                return _inventario; 
            }
            return _inventario  = new InventarioRepository(_context);
        }
    }

    public ITalla Tallas 
    {
        get
        {
            if( _talla is not null)
            {
                return _talla;
            }
            return _talla = new TallaRepository(_context);
        }
    }

    public IDetalleVenta DetalleVenta 
    {
        get
        {
            if( _detalleVenta is not null)
            {
                return _detalleVenta;
            }
            return _detalleVenta  = new DetalleVentaRepository(_context);
        }
    }

    public IDepartamento Departamentos 
    {
        get
        {
            if( _departamento is not null)
            {
                return _departamento;
            }
            return _departamento = new DepartamentoRepository(_context);
        }
    }

    public IPrenda Prendas 
    {
        get
        {
            if( _prenda is not null)
            {
                return _prenda; 
            }
            return _prenda  = new PrendaRepository(_context);
        }
    }

    public IProveedor Proveedores 
    {
        get
        {
            if( _proveedor is not null)
            {
                return _proveedor;
            }
            return _proveedor = new ProveedorRepository(_context);
        }
    }

    public IEmpleado Empleados 
    {
        get
        {
            if( _empleado is not null)
            {
                return _empleado;
            }
            return _empleado = new EmpleadoRepository(_context);
        }
    }

    public ICargo Cargos 
    {
        get
        {
            if( _cargo is not null)
            {
                return _cargo;
            }
            return _cargo = new CargoRepository(_context);
        }
    }

    public IVenta Ventas 
    {
        get
        {
            if(_venta is not null)
            {
                return _venta;
            }
            return _venta = new VentaRepository(_context);
        }
    }

    public IMunicipio Municipios 
    {
        get
        {
            if(_municipio is not null)
            {
                return _municipio;
            }
            return _municipio = new MunicipioRepository(_context);
        }
    }

    public IEmpresa Empresas 
    {
        get
        {
            if(_empresa is not null)
            {
                return _empresa;
            }
            return _empresa = new EmpresaRepository(_context);
        }
    }

    public ITipoProteccion TipoProtecciones 
    {
        get
        {
            if(_tipoProteccion is not null)
            {
                return _tipoProteccion;
            }
            return _tipoProteccion = new TipoProteccionRepository(_context);
        }
    }

    public IGenero Generos 
    {
        get
        {
            if(_genero is not null)
            {
                return _genero;
            }
            return _genero = new GeneroRepository(_context);
        }
    }

    public IEstado Estados 
    {
        get
        {
            if(_estado is not null)
            {
                return _estado;
            }
            return _estado = new EstadoRepository(_context);
        }
    }

    public ITipoEstado TipoEstados 
    {
        get
        {
            if(_tipoEstado is not null)
            {
                return _tipoEstado;
            }
            return _tipoEstado = new TipoEstadoRepository(_context);
        }
    }

    public IFormaPago FormaPagos 
    {
        get
        {
            if(_formaPago is not null)
            {
                return _formaPago;
            }
            return _formaPago = new FormaPagoRepository(_context);
        }
    }

    public IOrden Ordenes 
    {
        get
        {
            if(_orden is not null)
            {
                return _orden;
            }
            return _orden = new OrdenRepository(_context);
        }
    }

    public IColor Colores 
    {
        get
        {
            if(_color is not null)
            {
                return _color;
            }
            return _color = new ColorRepository(_context);
        }
    }

    public IDetalleOrden DetalleOrdenes 
    {
        get
        {
            if(_detalleOrden is not null)
            {
                return _detalleOrden;
            }
            return _detalleOrden = new DetalleOrdenRepository(_context);
        }
    }

    public ICliente Clientes 
    {
        get
        {
            if(_cliente is not null)
            {
                return _cliente;
            }
            return _cliente = new ClienteRepository(_context);
        }
    }

    public ITipoPersona TipoPersonas 
    {
        get
        {
            if(_tipoPersona is not null)
            {
                return _tipoPersona;
            }
            return _tipoPersona = new TipoPersonaRepository(_context);
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
