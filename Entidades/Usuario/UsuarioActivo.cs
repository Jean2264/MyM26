using System;
using System.Collections.Generic;
using System.Text;
using MyM26.Entidades.Usuario;

namespace MyM26.Entidades.Usuario
{
    public static class UsuarioActivo
    {
        
        public static VUser Datos{ get; set;  }

        public static void LimpiarSession()
        {
            Datos = null;
        }
    }
}
