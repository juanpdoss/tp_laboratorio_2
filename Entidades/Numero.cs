using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public class Numero
    {
     
            private double numero;



            public string setNumero
            {
                set
                {
                    numero = ValidarNumero(value);
                }
            }

            public string BinarioDecimal(string binario)
            {
                int numero = 0;
                string rta = "Valor invalido";
                int aux = 1;

                if (EsBinario(binario))
                {
                    for (int i = 0; i < binario.Length; i++)
                    {
                        if (binario[i] == '1')
                        {
                            numero = (int)(numero + 1 * Math.Pow(2, binario.Length - aux));
                            aux++;
                        }
                        else
                            continue;
                    }

                    rta = numero.ToString();

                }
                return rta;
            }

            public string DecimalBinario(double numero)
            {
                string rta = "Valor invalido";
                if (numero > 0)
                {
                    rta = Convert.ToString((int)numero, 2);
                }

                return rta;

            }
            public string DecimalBinario(string numero)
            {

                string rta = "Valor invalido";
                double aux;

                if (double.TryParse(numero, out aux))
                    rta = DecimalBinario(aux);

                return rta;

            }

            private bool EsBinario(string binario)
            {
                bool rta = false;
                int cont = 0;
                foreach (char aux in binario)
                {

                    if (aux == '1' || aux == '0')
                    {
                        rta = true;
                        cont++;
                    }

                }

                if (cont != binario.Length)
                {
                    rta = false;
                }

                return rta;
            }


            public Numero()
            {
                this.numero = 0;
            }

            public Numero(double numero)
            {
                this.numero = numero;

            }

            public Numero(string numero)
            {
                this.setNumero = numero;
            }

            private static double ValidarNumero(string strNumero)
            {
                double rta;

                if (double.TryParse(strNumero, out rta))
                { }
                else
                    rta = 0;

                return rta;
            }

            public static double operator -(Numero n1, Numero n2)
            {
                return n1.numero - n2.numero;

            }

            public static double operator *(Numero n1, Numero n2)
            {
                return n1.numero * n2.numero;

            }

            public static double operator /(Numero n1, Numero n2)
            {
                double rta = Double.MinValue;
                if (n2.numero != 0)
                {
                    rta = n1.numero / n2.numero;

                }
                return rta;
            }

            public static double operator +(Numero n1, Numero n2)
            {
                return n1.numero + n2.numero;
            }





    }
}

