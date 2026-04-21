using System;
using System.Collections.Generic;
using MyM26.DAL;
using MyM26.Entidades.Articulos;
using System.Text;

namespace MyM26.Entidades.Home
{
    public class VHome
    {
        public int  caja {  get; set; } = 0;
        public int venta {  get; set; } = 0;
        public int compra {  get; set; } = 0;
        public int articulo {  get; set; } = 0;
        public int proveedor {  get; set; } = 0;
        public int cliente { get; set; } = 0;
        public int usuario { get; set; } = 0;
        public int empleado { get; set; } = 0;

    }
}
