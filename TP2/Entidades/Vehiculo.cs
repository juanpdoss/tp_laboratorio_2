using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region enumerados

        public enum EMarca
        {
            Chevrolet, 
            Ford, 
            Renault, 
            Toyota, 
            BMW, 
            Honda, 
            HarleyDavidson
        }

        public enum ETamanio
        {
            Chico, 
            Mediano, 
            Grande
        }

        #endregion

        #region atributos   

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        #endregion

        #region constructor
        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        #endregion

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        /// 

        #region propiedades
        protected virtual ETamanio Tamanio
        {           
            get
            {
                return this.Tamanio;
            }
                
        }

        #endregion

        #region metodos
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>

        #region sobrecarga de operadores

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool sonIguales = false;

            //comparo por atributo chasis
            if(v1.chasis == v2.chasis)
            {
                sonIguales = true;
            }

            return sonIguales;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            //reutilizo el operador ==
            return !(v1.chasis == v2.chasis);
        }
        #endregion

        /// <summary>
        /// override del metodo Equals de Object, compara dos objetos del tipo vehiculo por su campo chasis, reutilizando el operador ==
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool sonIguales = false;

            //reutilizo el operador ==, por lo que internamente sigo comparado por atributo chasis
        
            if(obj is Vehiculo)
            {
                sonIguales = this == (Vehiculo)obj;
            }
       
            return sonIguales;    
        }

        /// <summary>
        /// override del metodo GetHashCode de Object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }
}
