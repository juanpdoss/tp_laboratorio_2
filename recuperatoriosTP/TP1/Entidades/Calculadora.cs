using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{   
    public static class Calculadora
    {
        /// <summary>
        /// Validara que el caracter recibido como parametro sea uno de los siguientes:
        /// '+', '-' , '*', '/'.
        /// </summary>
        /// <param name="operador" caracter a validar></param>
        /// <returns>Retorna el caracter en formato string si es valido, caso contrario retornara "+".</returns>
        private static string ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {

                return operador.ToString();

            }
            else
            {
                return "+";
            }

        }

        /// <summary>
        /// Realiza la operacion correspondiente entre dos objetos de tipo Numero basandose en el operador recibido como parametro
        /// </summary>
        /// <param name="num1" objeto de tipo Numero ></param>
        /// <param name="num2" objeto de tipo Numero></param>
        /// <param name="operador" caracter que indica la operacion a realizar></param>
        /// <returns> retorna el resultado de la operacion </returns>
        public static double Operar(Numero num1, Numero num2, char operador)
        {
            double rta = 0;
            string operadorValidado = Calculadora.ValidarOperador(operador);

            switch (operadorValidado)
            {
                case "-":
                    rta = num1 - num2;
                    break;
                case "*":
                    rta = num1 * num2;
                    break;
                case "/":
                    rta = num1 / num2;
                    break;
                case "+":
                    rta = num1 + num2;
                    break;


            }

            return rta;
        }

    }

}
   

