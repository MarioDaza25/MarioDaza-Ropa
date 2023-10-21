namespace API.Dtos;

public class TipoProteccionDto
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public ICollection<PrendaDto> Prendas { get; set; }

}
