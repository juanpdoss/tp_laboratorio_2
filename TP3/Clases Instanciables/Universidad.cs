using Archivos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    /// <summary>
    /// Clase instanciable Universidad 
    /// </summary>
    public class Universidad
    {
        #region atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region enumerado anidado
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD,
        }
        #endregion

        #region propiedades
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
        public List<Profesor> Instructores
        { get
            {
                return this.profesores;
            }

            set
            {
                this.profesores = value;
            }

        }
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }

            set
            {
                this.jornada = value;
            }

        }

        public Jornada this[int index]
        {
            //indexador
            get
            {
                if (index >= this.Jornadas.Count || index < 0)
                {
                    return null;
                }
                else
                {
                    return this.Jornadas[index];
                }
            }

            set
            {
                if (index >= 0 && index < this.Jornadas.Count)
                {
                    this.Jornadas[index] = value;
                }
                else if (index == this.Jornadas.Count)
                {
                    this.Jornadas.Add(value);
                }


            }
        }



        #endregion

        #region constructor

        /// <summary>
        /// Constructor por defecto, inicializa las listas.
        /// </summary>
        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Instructores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();

        }


        #endregion

        #region sobrecarga operadores 
        /// <summary>
        /// Un Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="g" Objeto de tipo Universidad></param>
        /// <param name="i" Objeto de tipo Profesor></param>
        /// <returns>True si el profesor esta en el atributo de tipo list<Profesor>, 
        /// false caso contrario.</profesores> </returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool daClases = false;
            foreach (Profesor item in g.Instructores)
            {
                if(item.Equals(i))
                {
                    daClases = true;
                    break;
                }

            }

            return daClases;

        }
        /// <summary>
        /// Un Universidad será distinto a un Profesor si el mismo no está dando clases en él.
        /// </summary>
        /// <param name="g" objeto de tipo Universiad></param>
        /// <param name="i" objeto de tipoProfesor></param>
        /// <returns> retorna true si el profesor no se en encuentra en el atributo de tipo list<Profesor>,
        /// false caso contrario.</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }


        /// <summary>
        /// Un Universidad será igual a un Alumno si el mismo está inscripto en él.
        /// </summary>
        /// <param name="g" objeto de tipo Profesor></param>
        /// <param name="a" objeto de tipo Alumno></param>
        /// <returns>Retorna true si el alumno se encuentra en el atributo de tipo list<Alumno>,
        /// false caso contrario.</alumnos></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool estaInscripto = false;

            foreach (Alumno item in g.Alumnos)
            {
                if(item.Equals(a))
                {
                    estaInscripto = true;
                    break;
                }

            }

            return estaInscripto;
        }
        /// <summary>
        /// Un Universidad será distinto a un Alumno si el mismo no está inscripto en él.
        /// </summary>
        /// <param name="g" objeto de tipo Universidad></param>
        /// <param name="a" objeto de tipo Alumno></param>
        /// <returns>Retorna true si el alumno no se encuentra en el atributo de tipo list<Alumno>
        /// false caso contrario.</alumnos></returns>
        public static bool operator !=(Universidad g,Alumno a)
        {
            return !(g == a);
        }
        /// <summary>
        /// Retornara el primer profesor capaz de dar la clase, caso contrario se lanzara una excepcion.
        /// </summary>
        /// <param name="u" Objeto de tipo Universidad></param>
        /// <param name="clases" Enumerado de tipo EClases></param>
        /// <returns>Un objeto de tipo Profesor.</returns>
        public static Profesor operator ==(Universidad u,EClases clases)
        {
            foreach (Profesor item in u.Instructores)
            {
                if (item == clases)
                {
                    return item;
                }
            }
            throw new SinProfesorException();

        }
        /// <summary>
        /// Retornara el primer profesor que no de la clase pasada como parametro.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clases"></param>
        /// <returns>Retorna un objeto de tipo Profesor</returns>
        public static Profesor operator !=(Universidad u,EClases clases)
        {
            Profesor profesor = default;
            foreach(Profesor item in u.Instructores)
            {
                if(item != clases)
                {
                    profesor = item;
                    break;
                }
            }

            return profesor;

        }

        /// <summary>
        /// Agregara un Alumno a la universidad validando que este no se encuentre en la misma antes de hacerlo.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns>Retorna un objeto de tipo Universidad.</returns>
        public static Universidad operator +(Universidad u,Alumno a)
        {
            if(u != a)
            {
                u.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return u;
        }

        /// <summary>
        /// Agregar un Profesor a la universidad,validando que este no se encuentre en la misma antes de hacerlo.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns>Retorna un objeto de tipo Universidad.</returns>
        public static Universidad operator +(Universidad u,Profesor i)
        {
            if(u != i)
            {
                u.Instructores.Add(i);
            }

            return u;
        }
        /// <summary>
        /// genera y agrega una nueva Jornada indicando la clase,
        /// un Profesor que pueda darla (según su atributo ClasesDelDia)
        /// y la lista de alumnos que la toman (todos los que coincidan en su campo ClaseQueToma).
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u,EClases clase)
        {
            //creo mi objeto jornada con el primer profesor disponible(operador ==) y la clase recibida.
            Jornada jornadaNueva = new Jornada(clase, u == clase);        
            foreach (Alumno item in u.Alumnos)
            {
                if(item == clase)
                {
                    jornadaNueva += item;
                }

            }

            int indice = u.Jornadas.Count;
            u[indice]=jornadaNueva;

            return u;
        }


        /// <summary>
        /// serializará los datos del Universidad en un XML, incluyendo todos los datos de sus
        /// Profesores, Alumnos y Jornadas.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> guardarXml = new Xml<Universidad>();

            return guardarXml.Guardar("universidad.xml", uni);
        }
        /// <summary>
        /// retorna un Universidad con todos los datos previamente serializados
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            Universidad aux = new Universidad();
            Xml<Universidad> leerXml = new Xml<Universidad>();
            leerXml.Leer("universidad.xml", out aux);
          
            return aux;

        }
        /// <summary>
        /// Retorna un string con todos los datos de un objeto Universidad
        /// </summary>
        /// <param name="uni" Objeto de tipo Univerisad></param>
        /// <returns></returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");
            for(int i=0; i<uni.Jornadas.Count ;i++)
            {
                sb.AppendLine(uni[i].ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Hara publicos los datos de esta instancia de Universidad 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        #endregion

    }
}
