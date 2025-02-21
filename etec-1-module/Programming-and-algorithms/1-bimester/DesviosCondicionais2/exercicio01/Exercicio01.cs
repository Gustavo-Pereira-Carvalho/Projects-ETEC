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

            Console.WriteLine("digite um número entre 0 e 100: ");
            int nm = int.Parse(Console.ReadLine());

            if (nm >= 0 && nm <= 100)
            {
                Console.WriteLine("Valor Válido: " + nm);
            }
            else
            {
                Console.WriteLine("Valor Inválido: " + nm);
            }
            Console.ReadKey();
        }
    }
}
