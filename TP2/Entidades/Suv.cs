using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{   /// <summary>
    /// clase publica Suv, hija de la clase Vehiculo. 
    /// </summary>
    public class Suv : Vehiculo
    {
        /// <summary>
        /// constructor de objeto, recibe los 3 parametros y reutiliza el constructor de Vehiculo.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
        }
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                //retorno mediano para coincidir con el ejecutable de ejemplo que se nos dio 
                return ETamanio.Mediano;
            }
        }
        /// <summary>
        /// override del metodo Mostrar de vehiculo, lista la camioneta agregando el tamanio
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
