using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Caja
{
    public class VentaDto
    {
      
       public DateTime FechaHora { get; set; }
        public string CodRemito { get; set; }
        public string DNI { get; set; }
        public string Cuit { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public string TipoComprobante { get; set; }
        public string Factura { get; set; }
        public string FormaPago { get; set; }
    }
}
