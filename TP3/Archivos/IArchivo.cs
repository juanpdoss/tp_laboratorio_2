using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    /// <summary>
    /// Interfaz generica IArchivo.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IArchivo<T>
    {
        /// <summary>
        /// escribe un archivo
        /// </summary>
        /// <param name="archivo"path del archivo></param>
        /// <param name="datos"datos a guardar></param>
        /// <returns></returns>
        bool Guardar(string archivo, T datos);
       

        /// <summary>
        /// lee un archivo 
        /// </summary>
        /// <param name="archivo" path del archivo></param>
        /// <param name="datos" datos a guardar></param>
        /// <returns></returns>
        bool Leer(string archivo,out T datos);

    }
}
