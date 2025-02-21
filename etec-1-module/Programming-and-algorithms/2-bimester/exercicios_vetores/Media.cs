using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_vetores
{
    class Media
    {
        static void Main(string[] args)
        {
            //Declare um array de doubles de 4 posições chamado notas.
            double[] notas = new double[4];
            //Faça um for para receber as notas:
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Informe a " + (i + 1) + "ª nota");
                notas[i] = double.Parse(Console.ReadLine());
            }
            //Calcule a media
            double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;
            //Exiba a média
            Console.WriteLine("Sua média foi " + media);
            Console.ReadKey();

        }
    }
}
