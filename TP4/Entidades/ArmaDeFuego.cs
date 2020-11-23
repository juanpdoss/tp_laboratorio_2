using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase publica istanciable, ArmaDeFuego.
    /// </summary>
    public class ArmaDeFuego : Arma
    {
        #region atributos
        int capacidadCargador;
        float calibre;
        #endregion

        #region propiedades
        /// <summary>
        /// Propiedad de solo lectura para el atributo capacidadCargador.
        /// </summary>
        public int CapacidadCargador 
        { 
            get
            {
                return this.capacidadCargador;
            }
            set
            {
                this.capacidadCargador = value;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura para el atributo calibre.
        /// </summary>
        public float Calibre
        {
            get
            {
                return this.calibre;
            }
            set
            {
                this.calibre = value;
            }
        }
        #endregion

        #region constructor
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public ArmaDeFuego()
        {

        }
        /// <summary>
        /// Constructor de instancia parametrizado.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="nombre"></param>
        /// <param name="capacidad"></param>
        /// <param name="calibre"></param>
        public ArmaDeFuego(int id, string descripcion, string precio, string nombre,int capacidad,float calibre) 
                        : base(id, descripcion, precio, nombre)
        {
            this.Calibre = calibre;
            this.CapacidadCargador = capacidad;
        }

        #endregion

        #region metodos
        /// <summary>
        /// Retorna en formato string todos los datos de un objeto de tipo ArmaDeFuego.
        /// </summary>
        /// <returns></returns>
        protected override string ArmaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ArmaToString());
            sb.AppendFormat("El cargador tiene una capacidad de {0} cartuchos\n" , this.capacidadCargador);
            sb.AppendLine("Calibre - " + this.Calibre);

            return sb.ToString();
        }
        /// <summary>
        /// Hara publico los datos de un objeto de tipo ArmaDeFuego.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.ArmaToString();
        }

        #endregion
    }
}
