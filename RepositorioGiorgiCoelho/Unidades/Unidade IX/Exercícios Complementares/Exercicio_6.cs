using System;

namespace UnidadeIX.cs.Exercícios_Complementares
{
    internal class Exercicio_6
    {
        public static void Maini(string[] args)
        {
            int[] vetor = new int[51];
            int[] gratuito = new int[51];
            int[] count = new int[51];

            for (int i = 1; i < vetor.Length; i++)
            {
                Console.Write("Quantos filmes o cliente " + i + " alugou? ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] >= 10)
                {
                    gratuito[i] = vetor[i];
                    if (vetor[i] == 10)
                    {
                        count[i]++;
                    }
                    else
                    {
                        do
                        {
                            vetor[i] = vetor[i] - 10;
                            count[i]++;
                        } while (vetor[i] >= 10);
                    }
                }
            }
            for (int i = 1; i < vetor.Length; i++)
            {
                Console.WriteLine("Cliente "+i+": Têm "+count[i]+" locações gratuitas!");
            }
            Console.ReadKey();
        }
    }
}