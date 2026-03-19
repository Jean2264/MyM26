using System;
using System.Collections.Generic;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using MyM26.DAL;
using System.Text;
using MyM26.Entidades.Articulos;

namespace MyM26.BLL
{
    public class ArticuloNegocio
    {
        public Resultado ValidarArticulo(VArticulo art)
        {
            Resultado resultado = new Resultado();

            //Nombre
            if(string.IsNullOrWhiteSpace(art.Nombre))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Nombre",
                    Mensaje="Este campo no puede quedar vacio."
                });
            }

            //Codigo de barras
            if(string.IsNullOrWhiteSpace(art.CodigoBarra))
            {
                resultado.Errores.Add(new Error
                {
                    Campo="CodigoBarra", 
                    Mensaje="Este campo no puede quedar vacio."
                });
            }
            else if(art.CodigoBarra.Length<8 || art.CodigoBarra.Length>15)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "CodigoBarra",
                    Mensaje = "El codigo de barra debe tener entre 8 y 15 caracteres numericos."
                });
            }

            //Categoria
            if(string.IsNullOrWhiteSpace(art.CodCategoria))
            {
                resultado.Errores.Add(new Error
                {
                    Campo="Categoria",                    
                    Mensaje = "Este campo no puede quedar vacio."
                });
            }

            //Subcategoria
            if(string.IsNullOrWhiteSpace(art.CodSubcategoria))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Subcategoria",
                    Mensaje = "Este campo no puede quedar vacio."
                });
            }

            //Proveedor
            if(string.IsNullOrWhiteSpace(art.cuitProv))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Proveedor",
                    Mensaje = "Este campo no puede quedar vacio."
                });
            }


            //Precio unitario
            if(string.IsNullOrWhiteSpace(art.PrecioUnitario.ToString().Trim()))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "PU",
                    Mensaje = "Este campo no puede quedar vacio."
                });
            }

            //Cantidad
            if(string.IsNullOrWhiteSpace(art.Cantidad.ToString().Trim())||art.Cantidad<1)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Cantidad",
                    Mensaje = "La cantidad no puede ser menor a 1."
                });
            }

           

            return resultado; 
        }

        public Resultado validarModi(VArticulo art)
        {
            var resultado = new Resultado();

            //Cantidad
            if (string.IsNullOrWhiteSpace(art.Cantidad.ToString().Trim()) || art.Cantidad < 1)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Cantidad",
                    Mensaje = "La cantidad no puede ser menor a 1."
                });
            }


            //Precio unitario
            if (string.IsNullOrWhiteSpace(art.PrecioUnitario.ToString().Trim()))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "PU",
                    Mensaje = "Este campo no puede quedar vacio."
                });
            }

            return resultado;
        }


        public Resultado ValidarParaCompra(VArticulo art)
        {
            var resultado = new Resultado();

            //Cantidad
            if (string.IsNullOrWhiteSpace(art.Cantidad.ToString().Trim()) || art.Cantidad < 1)
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Cantidad",
                    Mensaje = "La cantidad no puede ser menor a 1."
                });
            }

            //Proveedor
            if (string.IsNullOrWhiteSpace(art.cuitProv))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Proveedor",
                    Mensaje = "Este campo no puede quedar vacio."
                });
            }
            return resultado;

           
        }
        public VArticulo TomarInfo(string cod)
        {
            ArticuloDatos dta = new ArticuloDatos();
            return dta.TomarInfo(cod);
        }

        public VArticulo traerCompra(string cb)
        {
            ArticuloDatos dt = new ArticuloDatos();
           return dt.traerParaCompra(cb);
        }
      
        public VArticulo EliminarArt(string cod)
        {
            ArticuloDatos dt = new ArticuloDatos();
            return dt.BajaArt(cod);
        }
    }
}
