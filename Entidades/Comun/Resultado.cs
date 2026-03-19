using System;
using System.Collections.Generic;
using System.Text;
using static MyM26.BLL.UsuarioNegocio;

namespace MyM26.Entidades.Comun
{
   public class Resultado
    {
        
        
            public List<Error> Errores { get; set; } = new List<Error>();

        public bool EsValido => Errores.Count == 0;
    }
}
