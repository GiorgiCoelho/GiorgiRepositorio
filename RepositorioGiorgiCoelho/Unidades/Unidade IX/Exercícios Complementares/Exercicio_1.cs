using System;

namespace UnidadeIX.cs.Exercícios_Complementares
{
    internal class Exercicio_1
    {
        public static void Maini(string[] args)
        {
            int[] questao = new int[10];
            Random gerador = new Random();

            for (int i = 0; i < 10; i++)
            {
                questao[i] = gerador.Next(1, 4);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Questão [" + (i + 1) + "]: " + questao[i]);
                Console.WriteLine("-----------------------------");
            }
            Console.ReadKey();
        }
    }
}