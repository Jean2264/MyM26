using MyM26.DAL;
using MyM26.Entidades.Cliente;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Proveedor;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyM26.BLL
{
    public class ProveedorNegocio
    {

        public Resultado ValidarProveedor(VProveedor prov)
        {
            Resultado resultado = new Resultado();
            ///VALIDACIÓN DE CAMPOS///

            //CUIT
            if (string.IsNullOrWhiteSpace(prov.Cuit))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Cuit",
                    Mensaje = "El campo CUIT es obligatorio."
                });
            }
            else if (prov.Cuit.Length != 11 || !prov.Cuit.All(char.IsDigit))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Cuit",
                    Mensaje = "El campo CUIT debe tener 11 caracteres numéricos."
                });
            }

            //NOMBRE
            if (string.IsNullOrWhiteSpace(prov.Nombre))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Nombre",
                    Mensaje = "El campo Nombre es obligatorio."
                });
            }


            //ENTIDAD
            if (string.IsNullOrWhiteSpace(prov.Empresa))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Proveedor",
                    Mensaje = "El campo Proveedor es obligatorio."
                });
            }


            //TELEFONO
            if (string.IsNullOrWhiteSpace(prov.Telefono))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Telefono",
                    Mensaje = "El campo Teléfono es obligatorio."
                });
            }
            else if (prov.Telefono.Length < 10 || !prov.Telefono.All(char.IsDigit) || prov.Telefono.Length > 15)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Telefono",
                    Mensaje = "El campo Teléfono debe tener entre 10 y 15 caracteres numéricos."
                });
            }

            //MAIL
            if (string.IsNullOrWhiteSpace(prov.Mail))
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
                    prov.Mail,
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

        /* public VCliente ObtenerClientePorCuit(string cuit)
        {
            ClienteDatos datos = new ClienteDatos();
            return datos.tomarInfo(cuit);
        }

        public VCliente ObtenerResumenCliente(string cuit)
        {
            ClienteDatos datos= new ClienteDatos();
            return datos.ResumenCliente(cuit);
        }*/

        public VProveedor ObtenerProveedorPorCuit(string cuit)
        {
            ProveedorDatos datos = new ProveedorDatos();
            return datos.tomarInfo(cuit);
        }

        public VProveedor ObtenerResumenProveedor(string cuit)
        {
            ProveedorDatos datos = new ProveedorDatos();
            return datos.resumenProv(cuit);
        }

        /*  public VCliente eliminarCliente(string cuit)
        {
            ClienteDatos datos = new ClienteDatos();
            return datos.EliminarCliente(cuit);
        }*/

        public VProveedor EliminarProveedor(string cuit)
        {
            ProveedorDatos datos = new ProveedorDatos();
            return datos.EliminarProveedor(cuit);
        }
    }
}
