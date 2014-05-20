using System;

namespace UnidadeIX.cs
{
    internal class Exercicio_4
    {
        public static void Maini(string[] args)
        {
            int[] vetor1 = new int[12];
            int[] vetor2 = new int[12];
           
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Digite um valor: ");
                vetor1[i] = int.Parse(Console.ReadLine());                
                if (vetor1[i] == 0)
                {
                    vetor2[i] = 1; 
                }
                else
                {
                    vetor2[i] = vetor1[i];
                }
            }
            Console.Clear();
            Console.Write("Vetor 1:              Vetor 2:\n\n");
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("   "+vetor1[i]+"                     "+vetor2[i]);
            }

            Console.ReadKey();
        }
    }
}