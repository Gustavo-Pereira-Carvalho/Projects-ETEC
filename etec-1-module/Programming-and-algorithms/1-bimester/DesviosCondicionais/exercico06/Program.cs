using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercico06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número: ");
            int nm = int.Parse(Console.ReadLine());

            if(nm > 100)
            {
                Console.WriteLine("O número é maior que do que 100");
            }else if (nm == 100)
            {
                Console.WriteLine("O número é igual a 100");
            }
            else
            {
                Console.WriteLine("O número é menor do que 100");
            }
            Console.ReadKey();

        }
    }
}
