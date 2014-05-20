using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.cs.Exercícios_Complementares
{
    class Exercicio_7
    {
        public static void Maini(string[] args)
        {
            int[] vetorA = new int[51];
            int[] vetorB = new int[51];
            int soma = 0;
            Random gerador = new Random();

            for (int i = 1; i < vetorA.Length; i++)
            {
                vetorA[i] = gerador.Next(0, 1000);
                vetorB[51 - i] = gerador.Next(0, 1000);

                soma = soma + (vetorA[i] - vetorB[i]);
            }
            Console.WriteLine("Soma: "+soma);
            Console.ReadKey();
        }
    }
}
