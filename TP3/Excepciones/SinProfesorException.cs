using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que se lanza en los casos donde no hay un profesor para dar X clase.
    /// </summary>
    public class SinProfesorException:Exception
    {
        /// <summary>
        /// Constructor de instancia por defecto, asigna un mensaje.
        /// </summary>
        public SinProfesorException()
            :base("No hay profesor para la clase")
        {

        }

        /// <summary>
        /// Constructor de instancia que recibe una cadena como parametro.
        /// </summary>
        /// <param name="message" cadena a ser asignada como mensaje.></param>
        public SinProfesorException(string message)
            :base(message)
        {

        }




    }
}
