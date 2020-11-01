using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    /// <summary>
    /// clase abstracta persona
    /// </summary>
    public abstract class Persona
    {
        #region atributos
        private string apellido;
        private int dni;
        private string nombre;
        private ENacionalidad nacionalidad;
        #endregion

        #region enumerado anidado 
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion anidado

        #region propiedades
        /// <summary>
        /// Propiedad que retorna el atributo de cadena apellido, y lo establece (previa validacion).
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = Persona.ValidarNombreApellido(value);
            }
        }
        /// <summary>
        /// Propiedad que retorna y establece el atributo de tipo enumerado nacionalidad.
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }

            set
            {
                this.nacionalidad = value;
            }
        }
        /// <summary>
        /// Propiedad que retorna el atributo de tipo entero dni y lo establece (previa validacion).
        /// </summary>
        public int DNI  
        {
            get
            {
                return this.dni;
            }
            set
            {              
                this.dni = Persona.ValidarDni(this.nacionalidad,value);
            }
        }
        /// <summary>
        /// propiedad que solo establece el atributo de tipo cadena dni (previa validacion).
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = Persona.ValidarDni(this.Nacionalidad, value);
            }
        }
        /// <summary>
        /// Propiedad que retorna el atributo de tipo cadena nombre y lo establece (previa validacion).
        /// </summary>
        public string Nombre 
        { 
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = Persona.ValidarNombreApellido(value);

            }
                
        }
        #endregion propiedades 

        #region constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona() 
            
        {

        }
        /// <summary>
        /// Constructor de instancia parametrizado
        /// </summary>
        /// <param name="nombre" cadena que contiene el nombre></param>
        /// <param name="apellido" cadena que contiene el apellido></param>
        /// <param name="nacionalidad" enumerado de tipo ENacionalidad></param>
        public Persona(string nombre,string apellido,ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;

        }
        /// <summary>
        /// Constructor de instancia parametrizado
        /// </summary>
        /// <param name="nombre" cadena que contiene el nombre></param>
        /// <param name="apellido" cadena que contiene el apellido></param>
        /// <param name="dni" numero de dni></param>
        /// <param name="nacionalidad" enumerado de tipo ENacionalidad></param>
        public Persona(string nombre,string apellido,int dni,ENacionalidad nacionalidad)
                       :this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }
        /// <summary>
        /// Constructor de instancia parametrizado
        /// </summary>
        /// <param name="nombre" cadena que contiene el nombre></param>
        /// <param name="apellido" cadena que contiene el apellido></param>
        /// <param name="dni" cadena que contiene el numero de dni></param>
        /// <param name="nacionalidad" enumerado de tipo ENacionalidad></param>
        public Persona(string nombre,string apellido,string dni,ENacionalidad nacionalidad)
                       :this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion 

        #region metodos para validar 
        /// <summary>
        /// Valida que el numero de dni recibido como parametro se encuentre entre los rangos 1 y
        /// 89999999 para los argentinos, y  90000000 y 99999999 para los extranjeros
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>retorna el dni recibido como parametro si esta en los rangos correctos
        /// basandose en la nacionalidad, caso contrario se lanzara una excepcion </returns>
        private static  int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato < 1 || dato > 89999999)
                        throw new NacionalidadInvalidaException();
                    break;
                case ENacionalidad.Extranjero:
                    if (dato < 90000000 || dato > 99999999)
                        throw new NacionalidadInvalidaException();
                    break;
            }
            return dato;
        }

        /// <summary>
        /// Se validara que el DNI este conformado solo por numeros para llamar a la validacion numérica
        /// </summary>
        /// <param name="dato">DNI string a validar</param>
        /// <returns>Retorna el resultado de la validacion Numerica si el dato es valido,
        /// caso contrario se lanzara una excepcion del tipo DniInvalidoException</returns>
        private static int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int numeroDni;
            //valido el largo de la cadna
            if (dato.Length < 1 || dato.Length > 8)
            {
                throw new DniInvalidoException();
            } 

            //valido que solo este compuesto de caracteres numericos
            if (!Int32.TryParse(dato, out numeroDni))
                throw new DniInvalidoException();

            //si esta todo ok lo paso como parametro al validador Numerico
            return Persona.ValidarDni(nacionalidad, numeroDni);
        }

        /// <summary>
        /// Para validar que el nombre este compuesto solo por caracteres  a-z A-Z
        /// </summary>
        /// <param name="dato">Nombre o apellido a validar</param>
        /// <returns>Nombre o apellido validado si está todo OK, o un string vacio en caso de error</returns>
        private static string ValidarNombreApellido(string dato)
        {           
            // Expresión regular para buscar solo caracteres de la a a la z minúsculas y mayúsculas con N repeticiones
            if (Regex.IsMatch(dato, @"^[a-zA-Z]+$"))
            {
                return dato;
            }
            else
            {
                return "";
            }
        }

        #endregion

        #region override del ToString
        /// <summary>
        /// Retornara en una cadena todos los datos de un objeto Persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();         
            sb.AppendLine("NOMBRE COMPLETO: " + this.apellido + ", "+ this.nombre);
            sb.AppendLine("NACIONALIDAD: " + this.Nacionalidad.ToString());

            return sb.ToString();

        }

        #endregion 
    }
}
