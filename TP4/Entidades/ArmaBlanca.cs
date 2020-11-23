using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase publica instancible, ArmaBlanca.
    /// </summary>
    public class ArmaBlanca : Arma
    {
        #region atributos
        string material;
        float longitud;
        #endregion

        #region propiedades
        /// <summary>
        /// Propiedad de solo lectura para el campo material.
        /// </summary>
        public string Material
        {
            get
            {

                return this.material;

            }
            set
            {
                this.material = value;
            }

        }
        /// <summary>
        /// Propiedad de solo lectura para el campo longitud.
        /// </summary>
        public float Longitud
        {
            get
            {
                return this.longitud;

            }
            set
            {
                this.longitud = value;
            }
        }

        #endregion

        #region constructor
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public ArmaBlanca()
        {

        }
          
        /// <summary>
        /// Constructor de instancia parametrizado.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="nombre"></param>
        /// <param name="material"></param>
        /// <param name="longitud"></param>
        public ArmaBlanca(int id, string descripcion, string precio, string nombre,string material,float longitud) 
                                        :base(id, descripcion, precio, nombre)
        {
            this.Material = material;
            this.Longitud = longitud;
            
        }


        #endregion

        #region metodos

        /// <summary>
        /// Retornara en formato string los atributos de un objeto de tipo ArmaBlanca.
        /// </summary>
        /// <returns></returns>
        protected override string ArmaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ArmaToString());
            sb.AppendLine("Hecha de " + this.material);
            sb.AppendFormat("La hoja mide {0} centimetros.\n" , this.longitud);
            return sb.ToString();
            
        }

        /// <summary>
        /// Hara publicos los datos de un objeto de tipo ArmaBlanca.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.ArmaToString();
        }





        #endregion

    }
}
