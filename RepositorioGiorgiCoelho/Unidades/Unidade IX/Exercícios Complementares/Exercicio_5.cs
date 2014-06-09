using System;

namespace UnidadeIX.cs.Exercícios_Complementares
{
    internal class Exercicio_5
    {
        public static void Maini(string[] args)
        {
            string[] gabarito = new string[11];
            string[] alunos = new string[21];
            int[] pontuacao = new int[21];
            for (int i = 1; i < gabarito.Length; i++)
            {
                do
                {
                    Console.Write("Questão [" + i + "] do Gabarito: ");
                    gabarito[i] = Console.ReadLine();
                    if (gabarito[i] != "a" && gabarito[i] != "b" && gabarito[i] != "c" && gabarito[i] != "d")
                    {
                        Console.WriteLine("Sentenças de a até d!");
                    }
                } while (gabarito[i] != "a" && gabarito[i] != "b" && gabarito[i] != "c" && gabarito[i] != "d");
            }
            for (int i = 1; i < alunos.Length; i++)
            {
                Console.WriteLine("-------------------------------------");
                for (int z = 1; z < gabarito.Length; z++)
                {
                    do
                    {
                        Console.Write("Questão [" + z + "]: ");
                        alunos[i] = Console.ReadLine();
                        if (alunos[i] != "a" && alunos[i] != "b" && alunos[i] != "c" && alunos[i] != "d")
                        {
                            Console.WriteLine("Sentenças de a até d!");
                        }
                    } while (alunos[i] != "a" && alunos[i] != "b" && alunos[i] != "c" && alunos[i] != "d");

                    if (alunos[i] == gabarito[z])
                    {
                        pontuacao[i]++;
                    }
                    if (z == 10)
                    {
                        if (pontuacao[i] >= 6)
                            Console.WriteLine("Aluno " + i + ": Aprovado!");
                        else
                            Console.WriteLine("Aluno " + i + ": Reprovado!");
                    }
                }
            }
        }
    }
}