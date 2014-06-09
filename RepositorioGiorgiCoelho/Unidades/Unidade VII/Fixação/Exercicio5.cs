using System;

namespace Exercicios_Fixacao
{
    internal class Exercicio5
    {
        public static void Maini(String[] args)
        {
            int total_valor;
            do
            {
                Console.WriteLine("Quantidade máxima de valores? ");
                total_valor = int.Parse(Console.ReadLine());
            } while (total_valor % 2 == 0);

            Console.Clear();

            int[] valores = new int[total_valor + 1];
            int tamanho = total_valor;
            int aumento = 1;
            int aux = 0;

            for (int i = 1; i <= total_valor; i++)
            {
                for (int z = aumento; z <= tamanho; z++)
                {
                    valores[z] = z;
                    Console.Write(valores[z] + " ");
                }
                aux++;
                aumento++;
                tamanho--;
                Console.WriteLine("");
                for (int c = 1; c <= aux; c++)
                {
                    Console.Write("  ");
                }
            }

            Console.ReadKey();
        }
    }
}