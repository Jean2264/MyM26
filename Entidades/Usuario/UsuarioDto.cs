using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Usuario
{
    public class UsuarioDto
    {
        public string DNI { get; set; }
        public string Username { get; set; }
        public string Type { get; set; }

        public byte[] Foto { get; set; }
    }
}
