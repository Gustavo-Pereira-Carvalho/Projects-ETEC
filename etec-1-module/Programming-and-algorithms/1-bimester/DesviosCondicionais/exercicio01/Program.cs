using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1º número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2º número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if(numero1 > numero2)
            {
                Console.WriteLine("O maior número é: " + numero1);
            }else
            {
                Console.WriteLine("O maior número é: " + numero2);
            }
            Console.ReadKey();
        }
    }
}
