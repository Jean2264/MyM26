using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Proveedor
{
    public class VProveedor
    {
        public int UltimoId { get; set; }
        public int NuevoId { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public bool Estado { get; set; }
        public string Empresa { get; set; }

        //para resumen

        public int CantidadCompras { get; set; }
        public decimal TotalGastado { get; set; }
            public decimal TotalDescuento { get; set; }
            public DateTime? UltimaCompra { get; set; }

        //Para movimientos

        public int UltimiIdMovimiento { get; set; }
        public int NuevoIdMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public string DetalleMovimiento { get; set; }

    }
}
