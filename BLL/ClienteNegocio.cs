using MyM26.DAL;
using MyM26.Entidades.Cliente;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Usuario;
using MyM26.Querys;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyM26.BLL
{
    public class ClienteNegocio
    {

        public Resultado ValidarCliente(VCliente cliente)
        {
            Resultado resultado = new Resultado();

            ///VALIDACIÓN DE CAMPOS///

            //CUIT
            if (string.IsNullOrWhiteSpace(cliente.Cuit))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Cuit",
                    Mensaje = "El campo CUIT es obligatorio."
                });
            }
            else if (cliente.Cuit.Length != 11 || !cliente.Cuit.All(char.IsDigit))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Cuit",
                    Mensaje = "El campo CUIT debe tener 11 caracteres numéricos."
                });
            }

            //NOMBRE
            if(string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Nombre",
                    Mensaje = "El campo Nombre es obligatorio."
                });
            }
           

            //ENTIDAD
            if (string.IsNullOrWhiteSpace(cliente.Entidad))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Entidad",
                    Mensaje = "El campo Entidad es obligatorio."
                });
            }


            //TELEFONO
            if (string.IsNullOrWhiteSpace(cliente.Telefono))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Telefono",
                    Mensaje = "El campo Teléfono es obligatorio."
                });
            }
            else if (cliente.Telefono.Length < 10 || !cliente.Telefono.All(char.IsDigit) || cliente.Telefono.Length>15)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Telefono",
                    Mensaje = "El campo Teléfono debe tener entre 10 y 15 caracteres numéricos."
                });
            }

            //MAIL
            if (string.IsNullOrWhiteSpace(cliente.Mail))
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
                    cliente.Mail,
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

        public VCliente ObtenerClientePorCuit(string cuit)
        {
            ClienteDatos datos = new ClienteDatos();
            return datos.tomarInfo(cuit);
        }

        public VCliente ObtenerResumenCliente(string cuit)
        {
            ClienteDatos datos= new ClienteDatos();
            return datos.ResumenCliente(cuit);
        }
        public VCliente eliminarCliente(string cuit)
        {
            ClienteDatos datos = new ClienteDatos();
            return datos.EliminarCliente(cuit);
        }

    }
}
