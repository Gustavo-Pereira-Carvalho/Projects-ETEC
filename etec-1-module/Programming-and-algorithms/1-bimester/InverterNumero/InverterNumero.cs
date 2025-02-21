using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNumero
{
    class InverterNumero
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Digite um numero de 100 a 999");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("Jogo encerrado");
                    break;
                }
                else if (numero < 100 || numero > 999)
                {
                    Console.WriteLine("Número inválido. Por favor, digite um número entre 100 e 999.");
                    continue;
                }

                int temp = numero;
                int inverso = 0;

                while (temp != 0)
                {
                    int digito = temp % 10;
                    inverso = (inverso * 10) + digito;
                    temp /= 10;
                }
                Console.WriteLine($"Número digitado: {numero}");
                Console.WriteLine($"Inverso do número: {inverso}");

            } while (true);


        }
    }
}
