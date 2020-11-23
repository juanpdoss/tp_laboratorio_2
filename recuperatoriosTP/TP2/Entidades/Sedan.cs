using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    /// <summary>
    /// Clase publica Sedan, hija de la clase Vehiculo.
    /// </summary>
    public class Sedan : Vehiculo
    {
        #region atributos
        private ETipo tipo;
        #endregion

        #region enumerado
        public enum ETipo 
        { 
            CuatroPuertas,
            CincoPuertas,
        }
        #endregion

        #region propiedades
        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region constructores
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
                              :this(marca, chasis, color,ETipo.CuatroPuertas)
        {
           
        }
        /// <summary>
        /// contructor que recibe todos los parametros, asigna campo tipo. 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="Color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor Color,ETipo tipo)
                            :base(marca,chasis,Color)
        {
            this.tipo = tipo;

        }

        #endregion constructores 

        #region metodos
        /// <summary>
        /// override del Metodo mostrar de vehiculo, lista el sedan agregando el tipo.
        /// </summary>
        /// <returns></returns>
        public override  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
