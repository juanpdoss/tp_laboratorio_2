using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase publica y abstracta Arma.
    /// </summary>
    ///
    public abstract class Arma:IImpuestos
    {
        #region atributos
        private string nombre;
        private string descripcion;
        private float precio;
        private int id;
        #endregion

        #region propiedades

        //<summary>
        //Propiedad de lectura y escritura para el atributo descripcion.
        //</summary>
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }

        }
        /// <summary>
        /// Propiedad de lectura y escritura para el atributo precio
        /// </summary>
        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        /// <summary>
        /// Propiedad de escritura para el atributo Precio, lo establece previa validacion.
        /// </summary>
        public string StringPrecio
        {
            set
            {
                this.precio = Arma.ValidarNumerico(value);
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura para el id.
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }

        }

        /// <summary>
        /// Propiedad de lectura y escritura para el atributo nombre.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        #endregion

        #region constructor
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Arma()
        {

        }
        /// <summary>
        /// Costructor parametrizado, establece los atributos nombre, descripcion, precio, y id.
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="nombre"></param>
        public Arma(int id,string descripcion, string precio, string nombre)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.StringPrecio = precio;     
            this.Id = id;
            this.AplicarIva();
        }
        #endregion

        #region metodos
        /// <summary>
        /// Retorna en formato de string todos los datos de un objeto de tipo Arma.
        /// </summary>
        /// <returns></returns>
        protected virtual string ArmaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID- " + this.Id);
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Descripcion: " + this.Descripcion);
            sb.Append("Precio: " + this.Precio);
            return sb.ToString();
        }

        /// <summary>
        /// Valida que la cadena ingresara solo tenga numeros.
        /// </summary>
        /// <param name="precio" cadena a validar></param>
        /// <returns>retorna la cadena recibida en formato Float siempre y cuando solo incluya numeros
        /// caso contario se lanzara una excepcion.</returns>
        private static float ValidarNumerico(string precio)
        {
            float retorno;
            if (float.TryParse(precio,out retorno))
            {
                return Arma.EsPositivo(retorno);
            }
            else
            {
                throw new NumeroInvalidoException();
            }

           
        }
        /// <summary>
        /// Valida que el precio sea 0 y distinto de cero.
        /// </summary>
        /// <param name="precio"></param>
        /// <returns>Retorna el precio si pasa la validacion, caso contrario se lanzara una excepcion.</returns>
        private static float EsPositivo(float precio)
        {
            if (precio > 0)
                return precio;
            else
                throw new NumeroInvalidoException();
   
        }
        /// <summary>
        /// Valida que la cadena recibida como parametro este compuesta solo con letras.
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        private static string ValidarCadena(string cadena)
        {
          
            if(Regex.IsMatch(cadena, @"^[a-zA-Z]+$"))
            {
                return cadena;
            }
            else
            {
                return " ";
            }
        }

        /// <summary>
        /// Aumenta el atributo precio en un 21%
        /// </summary>
        /// <param name="arma"></param>
        public void AplicarIva()
        {
            this.precio*= (float)1.21;
            
        }

        #endregion


    }


}

