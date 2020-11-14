using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// clase publica Ciclomotor, hija de la clase Vehiculo.
    /// </summary>
    public class Ciclomotor : Vehiculo
    {
        #region constructor
        /// <summary>
        /// constructor de instancia, recibe los 3 parametros y reutiliza el constructor de Vehiculo.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
                            :base(marca,chasis,color)
        {


        }
        #endregion

        #region propiedades
        /// <summary>
        /// Las motos son chicas
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region metodos
        /// <summary>
        /// override del metodo Mostrar de vehiculo, lista la moto agregando el tamaño.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
