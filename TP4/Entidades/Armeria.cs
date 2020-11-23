using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase publica y estatica Armeria
    /// </summary>
    public static class Armeria    
    {      
        static float recaudado;
        static Armeria()
        {
            Armeria.recaudado = 0;
        }

        /// <summary>
        /// Propiedad de solo lectura para el campo recaudado.
        /// </summary>
        public static float Recaudado
        { 
            get
            {
                return Armeria.recaudado;

            }
                
        }

        /// <summary>
        /// Suma al atributo recaudado el precio del armaDeFuego recibida por parametro.
        /// </summary>
        /// <param name="arma"></param>
        /// <returns>Retorna true si logra asignar un valor al atributo, false caso contrario.</returns>
        public static bool Vender(ArmaDeFuego arma)
       {
            bool vendio = false;

            if(arma.Precio!=0)
            {
                Armeria.recaudado += arma.Precio;
                vendio = true;
            }

            return vendio;
       }

        /// <summary>
        /// Suma al atributo recaudado el precio del armaBlanca recibida por parametro.
        /// </summary>
        /// <param name="arma"></param>
        /// <returns>Retorna true si logra asignar un valor al atributo, false caso contrario.</returns>
        public static bool Vender(ArmaBlanca arma)
        {
            bool vendio = false;

            if (arma.Precio != 0)
            {
                Armeria.recaudado += arma.Precio;
                vendio = true;
            }

            return vendio;

        }

       


    }
}
