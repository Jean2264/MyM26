using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Empleado
{
    public class VEmpleado
    {
        public int UltimoId { get; set; }
        public int NuevoId { get; set; }
        public string DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Seccion { get; set; }


        //Para movimientos

        public int UltimiIdMovimiento { get; set; }
        public int NuevoIdMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public string DetalleMovimiento { get; set; }
    }
}
