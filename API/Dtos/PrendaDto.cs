namespace API.Dtos;

public class PrendaDto
{
    public int Id { get; set; }
    public int IdPrenda { get; set; }
    public string Nombre { get; set; }
    public decimal ValorUnitCop { get; set; }
    public decimal ValorUnitUsd { get; set; }
    public int Id_Estado { get; set; }
    public int Id_TipoProteccion { get; set; }
    public int Id_Genero { get; set; }
}
