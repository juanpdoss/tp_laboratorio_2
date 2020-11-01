using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que se lanza cuando se presenta un error al manejar archivos.
    /// </summary>
    public class ArchivosException:Exception
    {
        /// <summary>
        /// Constructor de instancia por defecto, asigna un mensaje.
        /// </summary>
       public ArchivosException()
            :base("Error de archivos")
       {

       }
       /// <summary>
       /// Constructor de instancia que recibe un string como parametro.
       /// </summary>
       /// <param name="message" cadena que sera asignada como mensaje></param>
       public ArchivosException(string message)
            :base(message)           
       {


       }
       /// <summary>
       /// Constructor de instancia que recibe un objeto de tipo Exception como parametro.
       /// </summary>
       /// <param name="innerException" Objeto de tipo Exception></param>
       public ArchivosException(Exception innerException)
            :base(innerException.Message)
       {
            //Agregue este constructor ya que se encontraba en el diagrama
            //El constructor por defecto que asigna un mensaje y el que recibe un string, los pide el enunciado.
       }

    }
}
