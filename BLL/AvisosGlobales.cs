using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.BLL
{
   public static class AvisosGlobales
    {
        //Este evento es el que todos pueden escuchar
        public static event Action OnCompraFinalizada;

        //Este metodo lo llaman las pantallas que un proceso
        public static void AvisarCompraFinalizada()
        {
            OnCompraFinalizada?.Invoke();
        }
    }
}
