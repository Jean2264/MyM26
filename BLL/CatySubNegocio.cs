using System;
using System.Collections.Generic;
using System.Text;
using MyM26.Entidades.CatySub;
using MyM26.Entidades.Comun;
using MyM26.DAL;
namespace MyM26.BLL
{
   public  class CatySubNegocio
    {

        //PARA CATEGORIA
        public Resultado ValidarCategoria(VCatySub cat)
        {
            Resultado resultado = new Resultado();

            if(string.IsNullOrWhiteSpace(cat.Categoria) )
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Categoria",
                    Mensaje = "La categoría no puede estar vacía."
                } );
            }

            return resultado;
        }




        //PARA SUBCATEGORIA

        public Resultado ValidarSubcategoria(VCatySub subcat)
        {
            Resultado resultado = new Resultado();

            if (string.IsNullOrWhiteSpace(subcat.CodCatRef) || subcat.CodCatRef == "0")
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Categoria",
                    Mensaje = "La categoría no puede estar vacía."
                });
            }
            
            if(string.IsNullOrWhiteSpace(subcat.Subcategoria))
            {
                resultado.Errores.Add(new Error
                {
                    Campo = "Subcategoria",
                    Mensaje = "La subcategoría no puede estar vacía."
                });
            }

            return resultado;
        }
    }
}
