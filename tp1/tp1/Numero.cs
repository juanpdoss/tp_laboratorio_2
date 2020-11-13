using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //clase publica Numero, puede instanciarse 
    public class Numero
    {
        #region atributos
        private double numero;
        #endregion

        #region propiedades
        /// <summary>
        /// Propiedad de solo escritura que asigna el atributo numero previa validacion.
        /// </summary>
        public string SetNumero 
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region constructores 
        //constructor de instancia por defecto.
        public Numero()
        {
            
        }

        //Constructor de instancia, recibe un double como parametro.
        public Numero(double numero):this(numero.ToString())
        {
           
        }

        //constructor que recibe un string como parametro.
        public Numero(string strNumero) 
        {

            this.SetNumero = strNumero;
        }
        #endregion

        #region metodos 
        /// <summary>
        /// Valida que la cadena recibida como parametro sea un numero binario y lo retorna en formato decimal,
        /// caso contrario retornara "valor invalido".
        /// </summary>
        /// <param name="binario" cadena que contiene el numero en binario></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            int numero = 0;
            string retorno = "Valor invalido";

            if (EsBinario(binario))
            {
                numero = Convert.ToInt32(binario, 2);
                retorno = Convert.ToString(numero);
            }
            return retorno;
        }

        /// <summary>
        /// Convierte, en caso de ser posible, el numero decimal recibido como parametro a su representacion en binario
        /// </summary>
        /// <param name="numero" numero en base decimal></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor invalido";
            if (numero > 0)
            {
                retorno = Convert.ToString((int)numero, 2);
            }

            return retorno;

        }
        /// <summary>
        /// Convierte, en caso de ser posible, el numero decimal contenido en la cadena recibida como parametro
        /// a su representacion en binario
        /// </summary>
        /// <param name="numero" cadena que contiene el numero></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {

            string respuesta = "Valor invalido";
            double auxiliar;

            if (double.TryParse(numero, out auxiliar))
            {
                respuesta = DecimalBinario(auxiliar);
            }


            return respuesta;

        }
        /// <summary>
        /// valida que la cadena recibida esta compuesta solo por unos y ceros, caso contrario se retornara false.
        /// </summary>
        /// <param name="binario" cadena que contiene el numero en binario></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            bool retorno = false;
            int cont = 0;
            foreach (char aux in binario)
            {

                if (aux == '1' || aux == '0')
                {
                    retorno = true;
                    cont++;
                }

            }

            if (cont != binario.Length)
            {
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que la cadena recibida como parametro sea un valor numerico, caso contrario se retornara cero.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private static double ValidarNumero(string strNumero)
        {
            double numeroValidado;

            if (!double.TryParse(strNumero, out numeroValidado))
            {
                numeroValidado = 0;
            }


            return numeroValidado;
        
        }
        #endregion

        #region sobrecarga de operadores 
        /// <summary>
        /// retorna la diferencia de los campos numero de dos objetos Numero.
        /// </summary>
        /// <param name="num1" objeto de tipo Numero ></param>
        /// <param name="num2" objeto de tipo Numero></param>
        /// <returns></returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// retorna la suma de los campo numero de dos objetos Numero.
        /// </summary>
        /// <param name="num1" objeto de tipo Numero></param>
        /// <param name="num2" objeto de tipo Numero></param>
        /// <returns></returns>
        public static double operator +(Numero num1,Numero num2)
        {
           
           return num1.numero + num2.numero;
        }

        /// <summary>
        /// retorna el producto de los campos numero de dos objetos Numero.
        /// </summary>
        /// <param name="num1" objeto de tipo Numero ></param>
        /// <param name="num2" objeto de tipo Numero ></param>
        /// <returns></returns>

        public static double operator * (Numero num1,Numero num2)
        {   
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// retorna la division de los campos numero de dos objetos Numero, en caso de que num2 sea cero, retornara double.MinValue.
        /// </summary>
        /// <param name="num1" objeto de tipo Numero ></param>
        /// <param name="num2" objeto de tipo Numero ></param>
        /// <returns></returns>
        public static double operator / (Numero num1, Numero num2)
        {
            double resultado = double.MinValue;

            if(num2.numero != 0)
            {
                resultado = num1.numero / num2.numero;
            }

            return resultado;

        }



        #endregion

    }
}
