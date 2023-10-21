using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class DetalleConPrendaDto
    {
        public int Id { get; set; }
        public PrendaNombreDto Prenda { get; set; }
        public int CantidadProducir { get; set; }
        public int CantidadProducida { get; set; }
    
    }
}