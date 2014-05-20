using System;

namespace UnidadeIX.cs.Exercícios_Complementares
{
    internal class Exercicio_2
    {
        public static void Maini(string[] args)
        {
            string[,] vagas = new string[5, 11];
            Random gerador = new Random();
            int aux;

            for (int i = 1; i < 5; i++)
            {
                for (int z = 1; z < 11; z++)
                {
                    aux = gerador.Next(0, 2);
                    if (aux == 0)
                    {
                        vagas[i, z] = "Vaga Vazia!";
                    }
                    else
                    {
                        vagas[i, z] = "Vaga Ocupada!";
                    }
                }
            }
            for (int i = 1; i < 5; i++)
            {
                for (int z = 1; z < 11; z++)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Andar [" + i + "] - Vaga [" + z + "]: " + vagas[i, z]);
                    Console.WriteLine("---------------------------------------------");
                }
            }

            Console.ReadKey();
        }
    }
}