using Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{
    /// <summary>
    /// Clase instanciable Jornada
    /// </summary>   
    public class Jornada
    {
        #region atributos

        private List<Alumno> alumnos;
        private EClases clases;
        private Profesor instructor;
        #endregion

        #region propiedades
        /// <summary>
        /// Propieda que retorna y establece el atributo de tipo lista alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }

            set
            {
                this.alumnos = value;
            }
        }
        /// <summary>
        /// propieda que retorna y establece el atributo de tipo enumerado clases
        /// </summary>
        public EClases Clase
        {
            get
            {
                return this.clases;

            }
            set
            {
                this.clases = value;
            }
        }

        /// <summary>
        /// propiedad que retorna y establece el atributo de tipo Profesor instructor
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;

            }
        }

        #endregion

        #region constructores
        /// <summary>
        /// Constructor por defecto,inicializa la lista de Alumnos
        /// </summary>
        private Jornada()
        {
            this.Alumnos = new List<Alumno>();

        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="clase" enumerado de tipo EClases></param>
        /// <param name="instructor" objeto de tipo Profesor></param>
        public Jornada(EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }


        #endregion

        #region metodos
        /// <summary>
        /// guardará los datos de la Jornada en un archivo de texto
        /// </summary>
        /// <param name="jornada" objeto de tipo Jornada></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();

            return texto.Guardar("jornada.txt",jornada.ToString());
        }

        /// <summary>
        /// Lee un archivo de texto.
        /// </summary>
        /// <returns> un string con el archivo leido</returns>
        public static string Leer()
        {
            string cadenaDeRetorno = "";
            Texto texto = new Texto();
            texto.Leer("jornada.txt", out cadenaDeRetorno);

            return cadenaDeRetorno;
        }
         
        /// <summary>
        /// mostrará todos los datos de la Jornada.
        /// </summary>
        /// <returns>una cadena con todos los datos de una Jornada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ClASE DE: " + this.clases.ToString());          
            sb.AppendLine(" POR " + this.instructor.ToString());
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno item in this.Alumnos)
            {
                sb.AppendLine(item.ToString());

            }
            sb.AppendLine("<------------------------------->");
            return sb.ToString();
        }

        #endregion

        #region sobrecarga de operadores
        /// <summary>
        /// una jornada y un alumno seran iguales si este participa en la clase
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool sonIguales = false;

            if (a == j.Clase)
            {
                sonIguales = true;
            }

            return sonIguales;
        }
        /// <summary>
        /// una jornada y un alumno seran distintos si este no participa en la jornada 
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        /// <summary>
        /// agrega un alumno a la jornada validando que este no se enuentre en la misma
        /// </summary>
        /// <param name="j" ></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j,Alumno a)
        {
            if(!j.Alumnos.Contains(a))
            {
                j.Alumnos.Add(a);
            }

            return j;
        }


        #endregion

    }
}
