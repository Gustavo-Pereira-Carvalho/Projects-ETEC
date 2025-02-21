using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual tabuada você quer ?");
            int numero = int.Parse(Console.ReadLine()) ;
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
            Console.ReadKey();
        }
    }
}
