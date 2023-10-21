namespace API.Dtos;

public class DetalleOrdenDto
{
    public int Id { get; set; }
    public int Id_Orden { get; set; }
    public PrendaNombreDto Prenda { get; set; }
    public int CantidadProducir { get; set; }
    public int Id_Color { get; set; }
    public int CantidadProducida { get; set; }
    public int Id_Estado { get; set; }
}
