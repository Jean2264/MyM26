using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Articulos
{
    public  class CompraDto
    {
        
                
         public DateTime FechaAlta { get; set; } 
          public string Descripcion { get; set; }
           public int Cantidad { get; set; }
          public decimal PrecioUnitario { get; set; }
          public decimal PrecioXCantidad { get; set; }
        public string DNI { get; set; }
        public string Cuit { get; set; }
                
    }
}
