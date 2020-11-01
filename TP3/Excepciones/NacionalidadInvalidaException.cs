using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que se lanza en los casos donde un numero de dni no concuerda con la nacionalidad.
    /// </summary>
    public class NacionalidadInvalidaException:Exception
    {
       /// <summary>
       /// Constructor de instancia por defecto, asigna un mensaje.
       /// </summary>     
       public NacionalidadInvalidaException()
            :base("La nacionalidad no se condice con el numero de DNI")
       {
           
       }

       /// <summary>
       /// Constructor de instancia, recibe una cadena como parametro.
       /// </summary>
       /// <param name="message" cadena a ser asignada como mensaje.></param>
       public NacionalidadInvalidaException(string message)
            :base(message)
       {

       }


    }
}
