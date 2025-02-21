using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    class Exercicio05
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
                int temp = n1;
                n1 = n2;
                n2 = temp;

            }
            if(n1 > n3)
            {
                int temp = n1;
                n1 = n3;
                n3 = temp;
            }
            if (n2 > n3)
            {
                int temp = n2;
                n2 = n3;
                n3 = temp;

            }
            Console.WriteLine("Valores em ordem crescente: " + n1 + ", " + n2 + ", " + n3);
            Console.ReadKey();
        }
    }
}
