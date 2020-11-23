using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Exception que se lanza al querer asignar un numero que sea negativo o contenga letras.
    /// </summary>
    public class NumeroInvalidoException:Exception
    {   
        /// <summary>
        /// Constructor que asigna un mensaje por defecto.
        /// </summary>
        public NumeroInvalidoException()
                    : base("Error, los numeros no pueden ser negativos ni pueden contener letras.")
        {

        }


        /// <summary>
        /// Constructor que asigna el mensaje recibido por parametro.
        /// </summary>
        /// <param name="message" mensaje a asignar.></param>
        public NumeroInvalidoException(string message)
                    :base(message)
        {

        }


    }
}
