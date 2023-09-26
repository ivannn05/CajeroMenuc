using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPruebaMenu.Servicios
{
   /// <summary>
   /// Interfaz con la relacion de metodos de la funcionalidad menu
   /// 250923 - ilp
   /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra mensaje de bienvenida al cajero
        /// </summary>
       
      
        public void mostrarMensajeBienvenida();
        
        /// <summary>
        /// Metodo que muestra el menu y recoge la selecion del usuario
        /// 260923 - ilp
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion(); 

    }

}
