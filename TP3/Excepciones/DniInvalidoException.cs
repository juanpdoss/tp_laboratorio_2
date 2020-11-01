using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que se lanza en los casos de dni de formato invalido.
    /// </summary>
    public class DniInvalidoException:Exception 
    {
        /// <summary>
        /// Constructor de instancia por defecto, asigna un mensaje.
        /// </summary>
        public DniInvalidoException()
            :base("El DNI ingresado no es valido.")
        {
            
        }
        /// <summary>
        /// Constructor de instancia que recibe un objeto de tipo Exception como parametro, asigna un mensaje.
        /// </summary>
        /// <param name="e" objeto de tipo Exception></param>

        public DniInvalidoException(Exception e)
          : base("El DNI ingresado no es valido.", e)
        {

        }
        /// <summary>
        /// Constructor de instancia que recibe una cadena como parametro.
        /// </summary>
        /// <param name="message" cadena a asignar como mensaje.></param>
        public DniInvalidoException(string message)
        : this(message, null)
        {

        }

        /// <summary>
        /// Constructor de instancia que recibe una cadena y un objeto de tipo Exception como parametros.
        /// </summary>
        /// <param name="message" cadena a asignar como mensaje.></param>
        /// <param name="e" objeto de tipo Exception></param>
        public DniInvalidoException(string message, Exception e)
            : base(message, e)
        {

        }


    }
}

