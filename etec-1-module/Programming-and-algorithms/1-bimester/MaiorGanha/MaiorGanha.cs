using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorGanha
{
    class MaiorGanha
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            

            int jogadas = 1;
            int pontosUsuario = 0;
            int pontosComputador = 0;

            do
            {
                int numPC = gerador.Next(1, 101);
                int numUsuario = gerador.Next(1, 101);

                Console.WriteLine($"\nseu numero é {numUsuario}. Apostar? (sim ou nao)");
                string resposta = Console.ReadLine();


                if (resposta == "sim")
                {
                    if (numUsuario > numPC)
                    {
                        Console.WriteLine($"\nParabéns! \nO número gerado foi ! {numPC}");

                        pontosUsuario++;
                    }
                    else if (numPC > numUsuario)
                    {
                        Console.WriteLine($"\nPerdeu! \nO número gerado foi ! {numPC}");
                        pontosComputador++;
                    }
                }
                else
                {
                    Console.WriteLine("Obrigado por jogar!");
                    break;
                }
                Console.WriteLine($"Você: {pontosUsuario} \nComputador: {pontosComputador} \njogadas: {jogadas++}");

            } while (true);

           


        

        }
            
       
    }
        

}
