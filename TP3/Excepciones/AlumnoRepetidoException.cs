using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que se lanza en los casos de alumno repetido.
    /// </summary>
    public class AlumnoRepetidoException:Exception
    {

        /// <summary>
        /// Constructor de instancia por defecto, asigna un mensaje.
        /// </summary>
        public AlumnoRepetidoException() 
            :base("Alumno repetido.")
        {

        }
        /// <summary>
        /// Constructor de instancia que recibe una cadena como parametro.
        /// </summary>
        /// <param name="message" cadena que sera asignada como mensaje></param>
        public AlumnoRepetidoException(string message)
            :base(message)
        {

        }


    }
}
