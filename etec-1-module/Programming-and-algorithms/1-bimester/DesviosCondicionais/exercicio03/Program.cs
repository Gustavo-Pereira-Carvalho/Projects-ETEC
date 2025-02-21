using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1º número:");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("2º número:");
            float numero2 = float.Parse(Console.ReadLine());
            float resultado = numero1 / numero2;
            float resultado2 = numero2 / numero1;

            if (numero1 > numero2)
            {
                Console.WriteLine("o resutado da divisão é:" + resultado);

            }else
            {
                Console.WriteLine("o resutado da divisão é:" + resultado2);
            }
            Console.ReadKey();
        }
    }
}
