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



        ///////////////PARA VENTA/////////////////////
        ///

        //Para HVenta
        /*create table HVenta
(
IdVenta int not null,
CodRemito varchar(10) unique not null,
DNI varchar(8),
Cuit varchar(11),
FechaHora datetime default getdate(),
SubTotal decimal(12,2),
Descuento decimal(12,2),
Total decimal(12,2),
Factura varchar(100),
FormaPago varchar(100),
primary key(IdVenta),
foreign key(DNI) references Usuario (DNI),
foreign key (Cuit) references Proveedor (Cuit)
)

create table HVentaDetalle
(
IdVentaDetalle int not null,
CodRDetalle varchar(10) unique not null,
CodRemito varchar(10),
CodigoArticulo varchar(10),
Descripcion varchar(100),
PrecioUnitario decimal(12,2),
Cantidad int,
PrecioXCantidad decimal(12,2),
primary key (IdVentaDetalle),
foreign key(CodRemito) references HVenta(CodRemito),
foreign key (CodigoArticulo) references Articulo (CodigoArticulo)
)*/
    }
}
