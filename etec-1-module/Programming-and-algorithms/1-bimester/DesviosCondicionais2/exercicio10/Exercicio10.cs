using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    class Exercicio10
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o 1º número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o º número: ");
            double n2 = double.Parse(Console.ReadLine());
            
            double sm = n1 + n2;
            double sub = n1 - n2;
            double mult = n1 * n2;
            double div = n1 / n2;
            double restdiv = (n1 * n2) / 100;

            Console.WriteLine("1- adição / 2- subtração / 3- multiplicação / 4- divisão / 5- resto da divisão");
            int op = int.Parse(Console.ReadLine());

            if( op == 1)
            {
                Console.WriteLine(n1 + " + " + n2 + " = " + sm);
            }else if (op == 2)
            {
                Console.WriteLine(n1 + " - " + n2 + " = " + sub);
            }else if (op == 3)
            {
                Console.WriteLine(n1 + " . " + n2 + " = " + mult);
            }else if (op == 4)
            {
                Console.WriteLine(n1 + " / " + n2 + " = " + div);
            }else if (op == 5)
            {
                Console.WriteLine(n1 + " % " + n2 + " = " + restdiv);
            }

          Console.ReadKey();
        }
    }
}
