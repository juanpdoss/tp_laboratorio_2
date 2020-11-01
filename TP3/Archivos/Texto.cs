using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    /// <summary>
    /// Clase publica Texto, implementa la interfaz IArchivo.
    /// </summary>
    public class Texto: IArchivo<string>
    {
        /// <summary>
        /// Escribe un archivo en formato string 
        /// </summary>
        /// <param name="archivo" path del archivo></param>
        /// <param name="datos" cadena a escribir en el archivo></param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            bool pudeGuardar = false;
            try
            {
                using(StreamWriter escritorTexto=new StreamWriter(archivo,true,Encoding.UTF8))
                {
                    escritorTexto.WriteLine(datos);
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
        /// Lee un archivo y lo retorna en formato string 
        /// </summary>
        /// <param name="archivo" path del archivo></param>
        /// <param name="datos" cadena donde se van a leer los datos></param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            bool pudeLeer = false;

            try
            {
                using(StreamReader lectorTexto = new StreamReader(archivo))
                {
                    datos = lectorTexto.ReadToEnd();
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
