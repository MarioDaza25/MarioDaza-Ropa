namespace Dominio.Entidades;

public class InventarioTalla
{
    public int Id_Inv { get; set; }
    public Inventario Inventario { get; set; }
    public int Id_Talla { get; set; }
    public Talla Talla { get; set; }
    public int Cantidad { get; set; }
}