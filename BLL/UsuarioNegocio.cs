using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Linq;

using System.Text.RegularExpressions;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using MyM26.DAL;

namespace MyM26.BLL
{
    public class UsuarioNegocio
    {

        public Resultado ValidarUsuario(VUser usuario)
        {
            Resultado resultado = new Resultado();

            //Validar dni
            if (string.IsNullOrWhiteSpace(usuario.Dni))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Dni",
                    Mensaje = "El campo DNI es obligatorio."
                });
            }
            else if (usuario.Dni.Length != 8 || !usuario.Dni.All(char.IsDigit))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Dni",
                    Mensaje = "El campo DNI debe tener 8 caracteres."
                });
            }

            //Validar nombre
            if (string.IsNullOrWhiteSpace(usuario.Nombre))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Nombre",
                    Mensaje = "El campo Nombre es obligatorio."
                });
            }
            else if(usuario.Nombre.Length<8 || usuario.Nombre.Length>16)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Nombre",
                    Mensaje = "El campo Nombre debe tener entre 8 y 16 caracteres."
                });
            }

            //Validar contrasenia
            if (string.IsNullOrWhiteSpace(usuario.Contrasenia))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Contrasenia",
                    Mensaje = "El campo Contraseña es obligatorio."
                });
            }
            else if (usuario.Contrasenia.Length < 8 || usuario.Contrasenia.Length > 16)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Contrasenia",
                    Mensaje = "El campo Contraseña debe tener entre 8 y 16 caracteres."
                });
            }
            else
            {
                bool tieneLetra = false;
                bool tieneNumero = false;
                foreach (char c in usuario.Contrasenia)
                {
                    if (char.IsLetter(c))
                        tieneLetra = true;
                    else if (char.IsDigit(c))
                        tieneNumero = true;
                    if (tieneLetra && tieneNumero)
                        break;
                }
                if (!tieneLetra || !tieneNumero)
                {
                    resultado.Errores.Add(new Error
                    {
                        Campo = "Contrasenia",
                        Mensaje = "El campo Contraseña debe contener al menos una letra y un número."
                    });
                }
            }
            if (usuario.Contrasenia != usuario.Repit)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Contrasenia",
                    Mensaje = "Las contraseñas no coinciden."
                });
            }

            UsuarioDatos datos= new UsuarioDatos();
            bool existeEnModificacion = datos.ExisteUsuarioEnModificacion(usuario.Nombre, usuario.Dni);

                if (existeEnModificacion)
                {
                    resultado.Errores.Add(new Error
                    {
                        Campo = "Nombre",
                        Mensaje = "El nombre de usuario ya existe en el sistema."
                    });
                }
    
               
            //validar telefono
            if (string.IsNullOrWhiteSpace(usuario.Telefono))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Telefono",
                    Mensaje = "El campo Teléfono es obligatorio."
                });

            }
            else if (usuario.Telefono.Length < 10 || !usuario.Telefono.All(char.IsDigit) || usuario.Telefono.Length > 15)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Telefono",
                    Mensaje = "El campo Teléfono debe tener entre 10 y 15 caracteres."
                });
            }

            // Validar email
            if (string.IsNullOrWhiteSpace(usuario.Mail))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Mail",
                    Mensaje = "El campo Mail es obligatorio."
                });
            }
            else
            {
                bool emailValido = Regex.IsMatch(
                    usuario.Mail,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
                );

                if (!emailValido)
                {
                    resultado.Errores.Add(new Error
                    {
                        Campo = "Mail",
                        Mensaje = "El campo Mail no tiene un formato válido."
                    });
                }
            }

            //Tipo
            if(string.IsNullOrWhiteSpace(usuario.Tipo))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Tipo",
                    Mensaje = "El campo Tipo es obligatorio."
                });
            }

            //Permisos

            bool tienePermiso =
                usuario.Cajas ||
                usuario.Ventas ||
                usuario.Articulos ||
                usuario.Clientes ||
                usuario.Proveedores ||
                usuario.Usuarios ||
                usuario.Contabilidad ||
                usuario.Compras;
            if (!tienePermiso)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Permisos",
                    Mensaje = "Debe seleccionar al menos un permiso."
                });
            }

                return resultado;
        }

        public VUser Tomarinfo( string dni)
        {
            UsuarioDatos datos= new UsuarioDatos();
           return datos.Tomarinfo(dni);
        }
        public VUser eliminarUser(string dni)
        {
            UsuarioDatos datos= new UsuarioDatos();

            return datos.ElimianrUser(dni);
        }

        public Resultado Validarlog(VUser usuario)
        {
            Resultado resultado = new Resultado();

            if (string.IsNullOrWhiteSpace(usuario.DNIAc) || string.IsNullOrWhiteSpace(usuario.NombreAc))
            {

                resultado.Errores.Add(new Error
                {
                    Campo = "Usuario",
                    Mensaje = "El campo es obligatorio para iniciar sesión."
                });
               

            }

            if(string.IsNullOrWhiteSpace(usuario.ContraseniaAc))

            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Contrasenia",
                    Mensaje = "El campo obligatorio para iniciar sesión."
                });
            }
            return resultado;
        }

        public Resultado ValidarUserRegitro(VUser usuario)
        {
            Resultado resultado = new Resultado();

            //Validar dni
            if (string.IsNullOrWhiteSpace(usuario.Dni))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Dni",
                    Mensaje = "El campo DNI es obligatorio."
                });
            }
            else if (usuario.Dni.Length != 8 || !usuario.Dni.All(char.IsDigit))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Dni",
                    Mensaje = "El campo DNI debe tener 8 caracteres."
                });
            }

            //Validar nombre
            if (string.IsNullOrWhiteSpace(usuario.Nombre))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Nombre",
                    Mensaje = "El campo Nombre es obligatorio."
                });
            }
            else if (usuario.Nombre.Length < 8 || usuario.Nombre.Length > 16)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Nombre",
                    Mensaje = "El campo Nombre debe tener entre 8 y 16 caracteres."
                });
            }

            //Validar contrasenia
            if (string.IsNullOrWhiteSpace(usuario.Contrasenia))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Contrasenia",
                    Mensaje = "El campo Contraseña es obligatorio."
                });
            }
            else if (usuario.Contrasenia.Length < 8 || usuario.Contrasenia.Length > 16)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Contrasenia",
                    Mensaje = "El campo Contraseña debe tener entre 8 y 16 caracteres."
                });
            }
            else
            {
                bool tieneLetra = false;
                bool tieneNumero = false;
                foreach (char c in usuario.Contrasenia)
                {
                    if (char.IsLetter(c))
                        tieneLetra = true;
                    else if (char.IsDigit(c))
                        tieneNumero = true;
                    if (tieneLetra && tieneNumero)
                        break;
                }
                if (!tieneLetra || !tieneNumero)
                {
                    resultado.Errores.Add(new Error
                    {
                        Campo = "Contrasenia",
                        Mensaje = "El campo Contraseña debe contener al menos una letra y un número."
                    });
                }
            }
            if (usuario.Contrasenia != usuario.Repit)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Contrasenia",
                    Mensaje = "Las contraseñas no coinciden."
                });
            }

           


            //validar telefono
            if (string.IsNullOrWhiteSpace(usuario.Telefono))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Telefono",
                    Mensaje = "El campo Teléfono es obligatorio."
                });

            }
            else if (usuario.Telefono.Length < 10 || !usuario.Telefono.All(char.IsDigit) || usuario.Telefono.Length > 15)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Telefono",
                    Mensaje = "El campo Teléfono debe tener entre 10 y 15 caracteres."
                });
            }

            // Validar email
            if (string.IsNullOrWhiteSpace(usuario.Mail))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Mail",
                    Mensaje = "El campo Mail es obligatorio."
                });
            }
            else
            {
                bool emailValido = Regex.IsMatch(
                    usuario.Mail,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
                );

                if (!emailValido)
                {
                    resultado.Errores.Add(new Error
                    {
                        Campo = "Mail",
                        Mensaje = "El campo Mail no tiene un formato válido."
                    });
                }
            }
            return resultado;
        }
        }
}

