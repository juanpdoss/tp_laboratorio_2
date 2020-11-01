using EntidadesAbstractas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{
    /// <summary>
    /// clase sellada y publica Profesor, hija de la clase Universitario
    /// </summary>
    public sealed class Profesor : Universitario
    {
        #region atributos
        private Queue<EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region constructores
        /// <summary>
        /// Constructor estatico privado, inicializa el atributo random.
        /// </summary>
       static Profesor()
       {
            Profesor.random = new Random();
       }
        /// <summary>
        /// constructor por defecto.
        /// </summary>
       public Profesor()
            :this(default,default,default,default,default)
       {
           
           
          
       }
        /// <summary>
        /// Constructor parametrizado, inicializa el atributo de tipo Queue
        /// </summary>
        /// <param name="id" numero delegajo del profesor></param>
        /// <param name="nombre" cadena nombre></param>
        /// <param name="apellido" cadena apellido></param>
        /// <param name="dni" cadena que contiene numero dni></param>
        /// <param name="nacionalidad" enumerado nacionalidad></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
                        :base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<EClases>();
            this._RandomClases();
            this._RandomClases();

        }

        #endregion

        #region metodos

        /// <summary>
        /// Retornara una cadena con el formato "CLASES DEL DIA: " concatenada al nombre de la clase que de ese dia el profesor.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA: ");
            foreach (EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Asigna al atributo ClasesDelDia la clase aleatoria asociada a los numeros que van del 0 al GetLength del enumerado EClases.
        /// </summary>
        private void _RandomClases()
        {
            this.clasesDelDia.Enqueue((EClases)random.Next(0, Enum.GetValues(typeof(EClases)).GetLength(0)));
           
        }
        /// <summary>
        /// retornara los datos de una instancia Profesor en formato String.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.Append(this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Hara publico los datos de una instancia profesor en formato string 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }


        #endregion

        #region sobrecarga operadores 
        /// <summary>
        /// Un profesor sera igual a una clase si este da la misma.
        /// </summary>
        /// <param name="i" Objeto de tipo Profesor></param>
        /// <param name="clase" Enumerado de tipo EClases></param>
        /// <returns>true si el profesor da la clase, false si no.</returns>
        public static bool operator ==(Profesor i,EClases clase)
        {
            bool daEsaClase = false;

            foreach (EClases item in i.clasesDelDia)
            {
                if(item == clase)
                {
                    daEsaClase = true;
                    break;
                }

            }

            return daEsaClase;
        }
        /// <summary>
        /// un profesor sera distinto a una clase si este no la da
        /// </summary>
        /// <param name="i" Objeto de tipo Profesor></param>
        /// <param name="clase" Enumerado de tipo EClases></param>
        /// <returns>true en caso de no dar la clase, false en caso contrario.</returns>
        public static bool operator !=(Profesor i,EClases clase)
        {
            return !(i == clase);
        }



        #endregion

    }
}
