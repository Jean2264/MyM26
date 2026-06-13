using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Articulos
{
    public class ArtViewDto
    {
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioXMayor { get; set; }
        public decimal Ganancia { get; set; }
        public int Cantidad { get; set; }
    }
}
