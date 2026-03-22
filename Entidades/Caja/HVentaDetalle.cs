using System;
using MyM26.DAL;
using MyM26.BLL;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Caja
{
    public class HVentaDetalle
    {
        /*create table HVentaDetalle
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

        //Para HVentaDetalle
        public int UltimoIdHVD { get; set; }
        public int NuvoIdHVD { get; set; }
        public string CodRDetalle { get; set; }
        public string CodRemito { get; set; }
        public string CodigoArticulo { get; set; }
        public string Descripcion { get; set; }
        public decimal PU { get; set; }
        public int CantidadV { get; set; }
        public decimal PXC { get; set; }

    }
}
