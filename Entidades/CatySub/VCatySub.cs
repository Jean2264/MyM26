using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.CatySub
{
    public class VCatySub
    {
        //Para categoria
        public int UltimoIdCategoria { get; set; }
        public string NuevoIdCategoria { get; set; }
        public string CodCategoria { get; set; }
        public string Categoria { get; set; }


        //para subcategoria

        public int UltimoIdSubcategoria { get; set; }
        public string NuevoIdSubategoria { get; set; }
        public string CodSubcategoria { get; set; }

        public string CodCatRef { get; set; }
        public string Subcategoria { get; set; }


        //Para moviemientos
        public int UltimoIdMov { get; set; }
        public int NuevoIdMov { get; set; }
        public string TipoMovimiento { get; set; }
        public string DetalleMovimiento { get; set;  }
    }
}
