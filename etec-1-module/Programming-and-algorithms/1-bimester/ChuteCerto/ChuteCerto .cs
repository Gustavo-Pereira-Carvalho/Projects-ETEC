using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCerto
{
    class InverterNumero
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int num1 = gerador.Next(1, 10);

            int pontosPC = 0;
            int pontosJogador = 0;
            do
            {
                Console.WriteLine("\ndigite um numero de 1 a 10");
                int numdig = int.Parse(Console.ReadLine());

                if(num1 == numdig)
                {
                    Console.WriteLine($"\nParabéns! \nO número gerado foi {num1}!");
                    pontosJogador++;
                }
                else
                {
                    Console.WriteLine($"\nPerdeu! \nO número gerado foi {num1}!");
                    pontosPC++;
                }
                Console.WriteLine($"Você: {pontosJogador} \nComputador: {pontosPC}");

            } while (true);
        }
    }
}
