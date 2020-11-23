using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase publica y generica Serializador.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Serializador<T> where T:Arma
    {
        /// <summary>
        /// Serializa el objeto de tipo T recibido como parametro.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Serializar(T obj)
        {
            bool pude = true;

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("arma.xml", Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(escritor, obj);
                }
            }
            catch(Exception e)
            {
                pude = false;
                throw e;
                
            }

            return pude;
        }

    }
}
