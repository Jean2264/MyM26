using System;
using MyM26.DAL;
using MyM26.BLL;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Caja
{
    public class VCaja
    {
        public string codigoArticulo { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioMayorista { get; set; }
        public int CantidadMinimaMayor { get; set; }
        public int StockDisponible { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal => Cantidad >= CantidadMinimaMayor ? Cantidad * PrecioMayorista : Cantidad * PrecioUnitario;

        public int cantArt { get; set; }

        ///////////////PARA VENTA/////////////////////
        ///





        //Para movimientos
        public int UltimiIdMovimiento { get; set; }
        public int NuevoIdMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public string DetalleMovimiento { get; set; }
    }
}
