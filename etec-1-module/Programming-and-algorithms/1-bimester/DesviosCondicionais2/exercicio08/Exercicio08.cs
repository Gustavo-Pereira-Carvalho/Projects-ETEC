using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
    class Exercicio08
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu salário: ");
            int sl = int.Parse(Console.ReadLine());
            
           

            if (sl <= 1000)
            {
                double au = sl * 0.10;
                double st = sl + au;
                Console.WriteLine("Salário anterior = " + sl+ "\nAumento =" + au + "\nSalário atual = " + st);

            }else if (sl <= 2000)
            {
                double au = sl * 0.08;
                double st = sl + au;
                Console.WriteLine("Salário anterior = " + sl + "\nAumento =" + au + "\nSalário atual = " + st);

            }else if (sl <= 3500)
            {
                double au = sl * 0.06;
                double st = sl + au;
                Console.WriteLine("Salário anterior = " + sl + "\nAumento =" + au + "\nSalário atual = " + st);
            }else if (sl <= 5000)
            {
                double au = sl * 0.04;
                double st = sl + au;
                Console.WriteLine("Salário anterior = " + sl + "\nAumento =" + au + "\nSalário atual = " + st);
            }
            else
            {
                double au = sl * 0.02;
                double st = sl + au;
                Console.WriteLine("Salário anterior = " + sl + "\nAumento =" + au + "\nSalário atual = " + st);
            }



            Console.ReadKey();
        }
    }
}
