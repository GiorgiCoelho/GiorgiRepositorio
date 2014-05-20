using System;

namespace UnidadeIX.cs.Exercícios_Complementares
{
    internal class Exercicio_3
    {
        public static void Maini(string[] args)
        {
            int[] vetor = new int[7];
            int menor_valor = 999999999;
            int pega_posicao = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um valor: ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] < menor_valor)
                {
                    pega_posicao = i;
                    menor_valor = vetor[i];
                }
            }

            Console.WriteLine("Menor Valor: " + menor_valor + ". Posição: " +0+(pega_posicao+1));
            Console.ReadKey();
        }
    }
}