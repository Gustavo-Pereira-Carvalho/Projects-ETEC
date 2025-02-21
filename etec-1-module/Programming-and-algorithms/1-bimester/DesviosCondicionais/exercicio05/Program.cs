using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1º número:");
            int nm1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2º número:");
            int nm2 = int.Parse(Console.ReadLine());
            int rs = nm1 * nm2;

            Console.WriteLine("o produto entre os dois é: " + rs);
            Console.ReadKey();
           
        }
    }
}
