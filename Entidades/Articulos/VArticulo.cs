using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Articulos
{
    public class VArticulo
    {

        //PARA ARTICULO
        
        public int UltimoIdArt {  get; set; }
        public int NuevoIdArt { get; set; }
        public string CodArt { get; set; }
        public string codArtRef { get; set; }
        public string CodigoBarra { get; set; }
        public byte[] Imagen {  get; set; }
        public string Nombre {  get; set; }
        public int CantMinMayor { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioXMayor { get; set; }
        public string CodCategoria { get; set; }
        public string Categoria {  get; set; }

        public string CodSubcategoria { get; set; }
        public string Subcategoria { get; set; }
        public string cuitProv {  get; set; }
        public string Prov {  get; set; }


        //PARA STOCK

        public int UltimoIdStock { get; set; }
        public int NuevoIdStock { get; set; }
        public string CodStock { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Ganancia { get; set; }
        


        //PARA HCOMPRA
        public int UltimoIdHC { get; set; }
        public int NuevoIdHC { get; set; }
        public string codHC { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        //PARA DETALLEHCOMPRA

        public int UltimoIdHCD { get; set; }
        public int NuevoIdHCD { get; set; }
        public string codHCD { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioXCantidad { get; set; }


        //PARA MOVIMIENTO
        public int UltimoIdMov { get; set; }
        public int NuevoIdMov { get; set; }
        public string TipoMovimiento { get; set; }
        public string DetalleMovimiento { get; set; }
        
}
}
