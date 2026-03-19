using MyM26.DAL;

using MyM26.Entidades.Comun;
using MyM26.Entidades.Empleado;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;


namespace MyM26.BLL
{
    public class EmpleadoNegocio
    {
        public Resultado ValidarEmpleado(VEmpleado empleado)
        {
            Resultado resultado = new Resultado();

            //DNI
            if (string.IsNullOrWhiteSpace(empleado.DNI))
            {
                resultado.Errores.Add(
                    new Error
                    {
                        Campo = "DNI",
                        Mensaje = "El DNI es obligatorio."
                    });
            }
            else if (empleado.DNI.Length != 8 || !empleado.DNI.All(char.IsDigit))
            {
                resultado.Errores.Add(
                   new Error
                   {
                       Campo = "DNI",
                       Mensaje = "El DNI debe tener exactamente 8 caracteres numericos."
                   });
            }

            //Apellido
            if (string.IsNullOrWhiteSpace(empleado.Apellido))
            {
                resultado.Errores.Add(
                    new Error
                    {
                        Campo = "Apellido",
                        Mensaje = "El apellido es obligatorio."
                    });
            }

            //Nombre
            if (string.IsNullOrWhiteSpace(empleado.Nombre))
            {
                resultado.Errores.Add(
                    new Error
                    {
                        Campo = "Nombre",
                        Mensaje = "El nombre es obligatorio."
                    });
            }

            //Telefono
            if (string.IsNullOrWhiteSpace(empleado.Telefono))
            {
                resultado.Errores.Add(
                    new Error
                    {
                        Campo = "Telefono",
                        Mensaje = "El telefono es obligatorio."
                    });

            }
            else if (empleado.Telefono.Length <10 || !empleado.Telefono.All(char.IsDigit))
            {
                resultado.Errores.Add(
                   new Error
                   {
                       Campo = "Telefono",
                       Mensaje = "El telefono debe tener como minimo entre 10 y 15 caracteres numericos."
                   });

               
            }

            //MAIL
            if (string.IsNullOrWhiteSpace(empleado.Mail))
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
                    empleado.Mail,
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

            if(string.IsNullOrWhiteSpace(empleado.Seccion))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Seccion",
                    Mensaje = "El campo Seccion es obligatorio."
                });
            }
            return resultado;
        }

        public VEmpleado ObtenerEmpleadoPorCuit(string dni)
        {
            EmpleadoDatos datos = new EmpleadoDatos();
            return datos.tomarInfo(dni);
        }


        public VEmpleado EliminarEmpleado(string dni)
        {
            EmpleadoDatos datos = new EmpleadoDatos();
            return datos.ELiminarEmpleado(dni);
        }

    }
}
