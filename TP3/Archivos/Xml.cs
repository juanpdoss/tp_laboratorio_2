using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    /// <summary>
    /// Clase publica y generica Xml, implementa la interfaz IArchivo.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Serializa y guarda un objeto de tipo T recibido como parametro
        /// </summary>
        /// <param name="archivo" ruta donde se guardara el archivo></param>
        /// <param name="datos" objeto a serializar></param>
        /// <returns>true en caso de poder haber serializado y guardado el objeto, false caso contrario.</returns>
        public  bool Guardar(string archivo, T datos)
        {
            bool pudeGuardar = false;

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(archivo,Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(escritor,datos);
                    pudeGuardar = true;
                }

            }
            catch(Exception e)
            {
                throw new ArchivosException(e.Message);
            }

            return pudeGuardar;
        }
      
        /// <summary>
        /// Lee un archivo de tipo Xml y lo asigna al objeto de tipo T pasado como parametro
        /// </summary>
        /// <param name="archivo" ruta del archivo></param>
        /// <param name="datos" objeto donde se asignara lo leido del archivo></param>
        /// <returns></returns>
        public bool Leer(string archivo,out T datos)
        {
            bool pudeLeer = false;

            try
            {   using (XmlTextReader lector = new XmlTextReader(archivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    datos=(T)serializer.Deserialize(lector);

                    pudeLeer = true;
                }

            }
            catch(Exception e)
            {
                throw new ArchivosException(e.Message);
            }


            return pudeLeer;
        }


    }
}
