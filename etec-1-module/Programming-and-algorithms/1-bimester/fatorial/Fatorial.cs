using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial
{
    class Fatorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um valor: ");
            int valor = int.Parse(Console.ReadLine());
            Console.Write(valor + "!");

            int soma = 1;
            for (int i = 1; i <= valor; i++)
            {
                Console.Write("*" + i);
                soma *= i;
            }
            Console.Write("=" + soma);

            Console.ReadKey();
        }
    }
}
