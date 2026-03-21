using System;
using System.Collections.Generic;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using MyM26.DAL;
using System.Text;
using MyM26.Entidades.Caja;

namespace MyM26.BLL
{
    public  class CajaNegocio
    {

        public VCaja tomarInfo(string cb)
        {
            CajaDatos dt = new CajaDatos();
            return dt.TraerArt(cb);
        }

        public VCaja BuscarAer(string filtro)
        {
            CajaDatos dt= new CajaDatos();
            return dt.ArtCajaBuscar(filtro);
        }
    }
}
