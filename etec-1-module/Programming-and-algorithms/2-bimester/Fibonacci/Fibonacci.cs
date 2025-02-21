using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("que posição da sequencia voce quer? ");
            int posicao = int.Parse(Console.ReadLine());

            int[] fibonacci = new int[posicao];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            //mostra as posições(dados) que  n iria mostrar no console
            Console.WriteLine("fibonacci [0] = " + fibonacci[0]);
            Console.WriteLine("fibonacci [1] = " + fibonacci[1]);

            //(int i + 2 fala que ira começar na 2º posição do vetor) ( i < posicao diz que so ira mostrar enquanto o i for menor que o numero pedido) (i++ vai aumentar  numero do fibonacci "vetor/array")
            for (int i = 2; i < posicao; i++)
            {
                //vai pegar a posição do i... fibonacci[i - 1] vai pegar o valor da posição anterior)... fibonacci[i -2] pega o valor de 2 posiçoes anteriores) e como tem um "+" entre eles, vai somar os dois valores.
                fibonacci[i] = (fibonacci[i - 1] + fibonacci[i - 2]);

                Console.WriteLine("fibonacci [" + i + "]=" + fibonacci[i]);
                
            }
            Console.ReadKey();
        }
    }
}
