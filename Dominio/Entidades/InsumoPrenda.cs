namespace Dominio.Entidades;

public class InsumoPrenda 
{
    public int Id_Insumo { get; set; }
    public Insumo Insumo { get; set; }
    public int Id_Prenda { get; set; }
    public Prenda Prenda { get; set; }
    public int Cantidad { get; set; }
}
