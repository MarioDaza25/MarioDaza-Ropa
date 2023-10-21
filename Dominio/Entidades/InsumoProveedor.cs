namespace Dominio.Entidades;

public class InsumoProveedor
{
    public int Id_Insumo { get; set; }
    public Insumo Insumo { get; set; }
    public int Id_Proveedor { get; set; }
    public Proveedor Proveedor { get; set; }
}
