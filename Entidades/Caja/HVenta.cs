using System;
using MyM26.DAL;
using MyM26.BLL;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using System.Collections.Generic;
using System.Text;
namespace MyM26.Entidades.Caja
{
    public class HVenta
    {
        //Para HVenta

        public int UltimoIdHV { get; set; }
        public int NuevoIdHV { get; set; }
        public string CodRemito { get; set; }
        public string Cuit { get; set; }
        public decimal SubtotalV { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public string TipoComprobante { get; set; }
        public string Factura { get; set; }
        public string FormaPago { get; set; }
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
 TipoComprobante varchar(200),
Factura varchar(100),
FormaPago varchar(100),
primary key(IdVenta),
foreign key(DNI) references Usuario (DNI),
foreign key (Cuit) references Proveedor (Cuit)
)*/


        //PARA MOVIMIENTO
        public int UltimoIdMov { get; set; }
        public int NuevoIdMov { get; set; }
        public string TipoMovimiento { get; set; }
        public string DetalleMovimiento { get; set; }
    }
}
