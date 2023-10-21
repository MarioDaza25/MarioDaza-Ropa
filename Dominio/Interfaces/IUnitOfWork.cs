namespace Dominio.Interfaces;

public interface IUnitOfWork
{
    IPais Paises {get;}
    IInsumo Insumos {get;}
    IInventario Inventarios {get;}
    ITalla Tallas {get;}
    IDetalleVenta DetalleVentas {get;}
    IDepartamento Departamentos {get;}
    IPrenda Prendas {get;}
    IProveedor Proveedores {get;}
    IEmpleado Empleados {get;}
    ICargo Cargos {get;}
    ICliente Clientes {get;}
    IVenta Ventas {get;}
    IMunicipio Municipios {get;}
    IEmpresa Empresas {get;}
    ITipoProteccion TipoProtecciones {get;}
    ITipoPersona TipoPersonas {get;}
    IGenero Generos {get;}
    IEstado Estados {get;}
    ITipoEstado TipoEstados {get;}
    IFormaPago FormaPagos {get;}
    IOrden Ordenes {get;}
    IColor Colores {get;}
    IDetalleOrden DetalleOrdenes {get;}
    IUsuario Usuarios {get;}
    IRol Roles {get;}
    Task<int> SaveAsync();
}
