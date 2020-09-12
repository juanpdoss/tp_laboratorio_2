using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        static private string ValidarOperador(char operador)
        {
            string retorno = "+";
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                retorno = operador.ToString();

            }

            return retorno;
        }

        static public double Operar(Numero num1, Numero num2, string operador)
        {

            double retorno = 0;

            string validado = ValidarOperador(Convert.ToChar(operador));

            switch (validado)
            {
                case "+":
                    retorno = num1 + num2;
                    break;

                case "-":
                    retorno = num1 - num2;
                    break;

                case "*":
                    retorno = num1 * num2;
                    break;

                case "/":
                    retorno = num1 / num2;
                    break;

            }


            return 0;

        }

    }
}

