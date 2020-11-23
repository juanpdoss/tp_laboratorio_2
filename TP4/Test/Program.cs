using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmaBlanca aux = new ArmaBlanca(23, "espada del rey", "3444", "excalivur" , "acero",45);
            try
            {
                //deberia lanzarse excepcion
                ArmaBlanca aux1 = new ArmaBlanca(24, "Espada pesada", "3a", "Espada flamigera", "hierro y cobre", 34);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine(aux.ToString());


            Armeria.Vender(aux);

            Console.WriteLine("recaudado: " + Armeria.Recaudado);
        

            Console.ReadLine();
        }
    }
}
