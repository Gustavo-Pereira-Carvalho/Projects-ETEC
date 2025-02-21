using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sinal está vermelho ou verde?");
            string sn = Console.ReadLine();

            if (sn == "vermelho")
            {
                Console.WriteLine("PARE!!!");

            }
            else if (sn == "verde")
            {
                Console.WriteLine("SIGA!!!");
            }
           


            else
            {
                Console.WriteLine("ERRO!!");
            }

            Console.ReadKey();
     
           
        }
    }
}
