using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Usuario
{
    public class VUser
    {

        //Para consultas y altas
        public int UltimoId {get; set;}
        public int NuevoId {get; set; }
        public int ultimoIdTipo {get; set; }
        public int NuevoIdTipo {get; set; }
        public string CodTipoUsuario {get; set; }
        //string dni, string nombre, string contrasenia, string repit, string telefono, string mail, string tipo
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public string Repit { get; set; }
        public string Telefono { get; set; }
        public string FechaAlta { get; set; }
        public string Mail { get; set; }
        public byte[] Foto { get; set; } 
      
        public bool Estado { get; set; }
        //Permisos
        public string Tipo { get; set; }
        public bool Cajas { get; set; }
        public bool Ventas { get; set; }
        public bool Articulos { get; set; }
        public bool Compras { get; set; }
        public bool Proveedores { get; set; }
        public bool Clientes { get; set; }
        public bool Usuarios { get; set; }
       public bool Contabilidad { get; set; }
        public bool Empleados { get; set; }

        //Para verificacion de existencia en modifiacion
        public string NombreOriginal { get; set; }
        public string ContraseniaOriginal { get; set; }
        public string NombreNuevo { get; set; }
        public string ContraseniaNueva { get; set; }


        //Para el login
        public  string DNIAc { get; set; }
        public  string NombreAc { get; set; }
        public string ContraseniaAc { get; set; }
        public  string TipoAc { get; set; }
        //public static Image Perfil { get; set;  }


        public bool CajasAc { get; set; }
        public bool ComprasAc { get; set; }
        public bool ProductosAC { get; set; }
        public bool VentasAc { get; set; }
        public bool UsuariosAc { get; set; }
        public bool ClientesAc { get; set; }
        public bool ProveedoresAc { get; set; }
        public bool ContableAc { get; set; }
        public bool EmpleadosAc { get; set; }
        public byte[] FotoAc { get; set; }
        public  Image PerfilImageAc { get; set; }


        //Para movimientos

        public int UltimiIdMovimiento { get; set; } 
        public int NuevoIdMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public string DetalleMovimiento { get; set; }

    }
}
