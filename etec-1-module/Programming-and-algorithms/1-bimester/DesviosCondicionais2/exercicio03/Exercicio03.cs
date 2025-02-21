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

            Console.WriteLine("digite o 1º numero: ");
            int nm1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o 2º numero: ");
            int nm2 = int.Parse(Console.ReadLine());
            
            if(nm1 > nm2)
            {
                Console.WriteLine(nm1 + " - " + nm2 + " é " + (nm1 - nm2));
            }else if(nm2 > nm1)
            {
                Console.WriteLine(nm2 + " - " + nm1 + " é " + (nm2 - nm1));
            }
            Console.ReadKey();
        }
    }
}
