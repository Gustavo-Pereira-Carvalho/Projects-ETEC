using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int totalJogador = 0;
            int totalBanca = 0;

            int cartaJogador1 = gerador.Next(1, 11);
            int cartaJogador2 = gerador.Next(1, 11);
            int cartaBanca1 = gerador.Next(1, 11);
            int cartaBanca2 = gerador.Next(1, 11);

            totalJogador = cartaJogador1 + cartaJogador2;
            totalBanca = cartaBanca1 + cartaBanca2;

            Console.WriteLine("Distribuido cartas...");
            Console.WriteLine($"Suas cartas são:  {cartaJogador1} e {cartaJogador2} ");
            Console.WriteLine("Total do jogador: {0}", totalJogador);



            while (totalJogador < 21)
            {

                Console.WriteLine("Deseja mais uma carta? (sim/nao)\n");
                string resposta = Console.ReadLine();

                if (resposta == "sim")
                {
                    int novaCarta = gerador.Next(1, 11);
                    totalJogador += novaCarta;
                    Console.WriteLine($"Nova carta: { novaCarta}");
                    Console.WriteLine($"Total do jogador: {totalJogador}");
                }
                else if (resposta == "nao")
                {
                    while (totalBanca < 17)
                    {
                        int novaCartaBanca = gerador.Next(1, 11);
                        totalBanca += novaCartaBanca;
                    }
                    Console.WriteLine($"\nTotal da banca: {totalBanca}");

                    if (totalJogador <= 21 && totalJogador > totalBanca || totalBanca > 21)
                    {
                        Console.WriteLine("Você ganhou!\n");
                    }
                    else if (totalJogador == totalBanca)
                    {
                        Console.WriteLine("Empate!\n");
                    }
                    else
                    {
                        Console.WriteLine("A banca ganhou!\n");
                    }
                }
            }
        
        }
    }
}
