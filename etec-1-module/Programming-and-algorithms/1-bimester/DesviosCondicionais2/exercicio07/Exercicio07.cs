using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
    class Exercicio07
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            int n3 = int.Parse(Console.ReadLine());

            if(n1 > n2)
            {
                n2 = n1 - n2;
                n1 = n1 - n2;
                n2 = n1 + n2;
            }
            if(n1 > n3)
            {
                n3 = n1 - n3;
                n1 = n1 - n3;
                n3 = n1 + n3;
            }
            if (n2 > n3)
            {
                n3 = n2 - n3;
                n2 = n2 - n3;
                n3 = n2 + n3;
            }
            Console.WriteLine("Valores em ordem crescente: " + n1 + ", " + n2 + ", " + n3);
            Console.ReadKey();

        }
    }
}
