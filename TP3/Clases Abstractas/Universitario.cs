using Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    /// <summary>
    /// clase abstracta Universitario, hija de la clase persona
    /// </summary>
    public abstract class Universitario:Persona
    {
        #region atributos propios  
        private int legajo;
        #endregion

        #region constructores
        /// <summary>
        /// Constructor de instancia por defecto
        /// </summary>
        public Universitario()
            :this(default,default,default,default,default)
        {

        }
        /// <summary>
        /// Constructor de instancia parametrizado
        /// </summary>
        /// <param name="legajo" numero legajo ></param>
        /// <param name="nombre" cadena que contiene el nombre></param>
        /// <param name="apellido" cadena que contiene el apellido></param>
        /// <param name="dni" cadena que contiene el numero de dni></param>
        /// <param name="nacionalidad" enumerado que contiene la nacionalidad></param>

        public Universitario(int legajo,string nombre,string apellido,string dni,ENacionalidad nacionalidad)
                                        :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region sobrecarga operadores
        /// <summary>
        /// Dos Universitarios serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="a" objeto de tipo universitario></param>
        /// <param name="b" objeto de tipo universitario></param>
        /// <returns>retorna true si ambas instancias son iguales, false caso contrario.</returns>

        public static bool operator ==(Universitario a,Universitario b)
        {
            bool sonIguales = false;
                
            if(a.GetType() == b.GetType() && (a.legajo == b.legajo || a.DNI == b.DNI))
            {                            
                   sonIguales = true;                
            }

            return sonIguales;

        }
        /// <summary>
        ///  Dos Universitario serán distintos si no son son del mismo Tipo, o su Legajo o DNI son distintos.
        /// </summary>
        /// <param name="a" objeto de tipo universitario></param>
        /// <param name="b" objeto de tipo universitario></param>
        /// <returns>retorna true si ambas instancias son distintas,false caso contrario.</returns>
        public static bool operator !=(Universitario a,Universitario b)
        {
            return !(a == b);
        }
        #endregion

        #region metodos
        /// <summary>
        /// retornará todos los datos del Universitario en formato string .
        /// </summary>
        /// <returns>cadena con los datos de un objeto de tipo Universitario</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();        
            sb.AppendLine(base.ToString());
            sb.AppendLine("LEGAJO NUMERO: " + this.legajo.ToString());

            return sb.ToString();
        }
        /// <summary>
        ///  Dos Universitarios serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="obj" objeto a comparar></param>
        /// <returns>true o false en funcion de si son o no, iguales.</returns>
        public override bool Equals(object obj)
        {
            bool sonIguales = false;

            if(obj is Universitario)
            {
                sonIguales = this == (Universitario)obj;
            }

            return sonIguales;

        }
        /// <summary>
        /// Metodo abstracto y protejido
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();


        #endregion
    }
}
