using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{
    /// <summary>
    /// clase sellada y publica Alumno, hija de la clase Universitario.
    /// </summary>
    public  sealed class Alumno:Universitario
    {
        #region atributos
        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #endregion

        #region Enumerado anidado
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado,

        }


        #endregion

        #region constructores
        /// <summary>
        /// Constructor de instancia por defecto 
        /// </summary>
        public Alumno()
            :this(default,default,default,default,default,default,default)
        {

        }
        /// <summary>
        /// Constructor de instancia parametrizado
        /// </summary>
        /// <param name="id" legajo del alumno></param>
        /// <param name="nombre" cadena que contiene el nombre></param>
        /// <param name="apellido" cadena que contiene el apellido></param>
        /// <param name="dni" cadena que contiene el numero de dni></param>
        /// <param name="nacionalidad" enumerado que contiene la nacionalidad></param>
        /// <param name="clasesQueToma" enumerado que contiene la clase></param>

        public Alumno(int id,string nombre,string apellido,string dni,
                ENacionalidad nacionalidad,EClases clasesQueToma)
                    :base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = clasesQueToma;

        }
        /// <summary>
        /// Constructor de instancia parametrizado
        /// </summary>
        /// <param name="id" legajo del alumno></param>
        /// <param name="nombre" cadena que contiene el nombre del alumno></param>
        /// <param name="apellido" cadena que contiene el apellidod del alumno></param>
        /// <param name="dni" cadena que contiene el numero de dni></param>
        /// <param name="nacionalidad" enumerado que contiene la nacionalidad></param>
        /// <param name="clasesQueToma" enumerado que contiene la clase></param>
        /// <param name="estadoCuenta" enumerado que contiene el estado de la cuenta></param>
        public Alumno(int id,string nombre,string apellido,string dni,
                    ENacionalidad nacionalidad,EClases clasesQueToma,EEstadoCuenta estadoCuenta)
                        :this(id,nombre,apellido,dni,nacionalidad,clasesQueToma)
     
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region metodos
        /// <summary>
        /// retornara la clase que toma el alumno (atributo: ECLASES claseQueToma)
        /// concatenada al texto "TOMA CLASE DE: ", en formato string. 
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE: " + this.claseQueToma.ToString();

        }
 

        /// <summary>
        /// retornara todos los datos del alumno en formato string
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("ESTADO CUENTA: " + this.estadoCuenta.ToString());
            sb.AppendLine(ParticiparEnClase());

            return sb.ToString();
        }
        /// <summary>
        /// retornara en forma publica los datos del alumno en formato string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }


        #endregion

        #region sobrecarga de operadores 
        /// <summary>
        /// Un alumno sera igual a una clase si este la tiene en su campo claseQueToma y ademas su estado no es deudor.
        /// </summary>
        /// <param name="a" objeto de tipo alumno></param>
        /// <param name="clase" enumerado que contiene la clase></param>
        /// <returns>retornara true si el alumno toma la clase y su campo estadoCuenta
        /// es distinto a deudor, false caso contrario.</returns>
        public static bool operator == (Alumno a,EClases clase)
        {
            bool sonIguales = false;

            if(a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                sonIguales = true;
            }

            return sonIguales;
        }
        /// <summary>
        /// Un alumno sera distinto a una clase solo si no la toma.
        /// </summary>
        /// <param name="a" objeto de tipo alumno></param>
        /// <param name="clases" enumerado que contiene la clase></param>
        /// <returns>retorna true si el alumno no toma la clase, false caso contrario</returns>
        public static bool operator !=(Alumno a,EClases clases)
        {
            bool sonDistintos = false;

            if(a.claseQueToma != clases)
            {
                sonDistintos = true;
            }

            return sonDistintos;
        }



        #endregion
    }
}
