using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gustavo Pereira";
            char genero = 'M';
            int idade = 16;
            double altura = 1.70;
            bool ensinomedio = true;
        
            Console.WriteLine("Nome: " + nome + "\nIdade: " + idade + "anos\nSexo: " + genero + "\nAltura: " + altura+ "\nEnsino Medio Cursando:"+ ensinomedio);
            Console.ReadKey();
            

        }
    }
}
