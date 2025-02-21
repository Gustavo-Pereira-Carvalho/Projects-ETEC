using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero%2==0) 
            {
                Console.WriteLine("O número " + numero + " é par");
            }else
            {
                Console.WriteLine("o número " + numero + " é impar");
            }
            Console.ReadKey();
        }
    }
}
