using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Articulos
{
    public class ArticuloDto
    {
        /* string consulta = @"SELECT a.CodigoArticulo, a.Nombre, a.PrecioUnitario, a.PrecioXMayor, a.Imagen, s.Cantidad FROM Articulo a 
                 INNER JOIN Stock s ON a.CodigoArticulo= s.CodigoArticulo WHERE a.Estado=1 ORDER BY a.Nombre OFFSET @offset ROWS
                    FETCH NEXT @limite ROWS ONLY";*/
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioXMayor { get; set; }
        public byte[] Imagen { get; set; }
        public int Cantidad { get; set; }
    }
}
