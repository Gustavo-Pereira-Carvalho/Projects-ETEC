using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
         

            for(int i= 1; i <= 50; i++)
            {
                int idade = gerador.Next(5, 90);
                
                if(idade >= 18)
                {
                    Console.WriteLine(idade + " é maior de de idade");
                }
                else
                {
                    Console.WriteLine(idade + " é menor de de idade");
                }
            }
            Console.ReadKey();
        }
    }
}
