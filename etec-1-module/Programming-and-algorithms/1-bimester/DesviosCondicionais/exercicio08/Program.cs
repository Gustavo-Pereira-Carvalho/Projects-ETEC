using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantidade de vitorias: ");
            int vt = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de derrotas: ");
            int dr = int.Parse(Console.ReadLine());

            if ( vt > dr)
            {
                Console.WriteLine("BOM!!!");
            }
            else
            {
                Console.WriteLine("RUIM!!!");
            }
            Console.ReadKey();
        }
    }
}
