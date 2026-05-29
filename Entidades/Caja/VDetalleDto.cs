using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Caja
{
    public class VDetalleDto
    {
       
        public string Descripcion { get; set; }
        public string CodRDetalle { get; set; }
        public int Cantidad { get; set; } = 0;
        public decimal PrecioXCantidad { get; set; }

    }
}
