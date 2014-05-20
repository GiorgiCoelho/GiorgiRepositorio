using System;

namespace UnidadeIX.cs
{
    internal class Exercicio_8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de jogadores: ");
            int quant_jogadores = int.Parse(Console.ReadLine());
            int[,] gabarito = new int[13, 3];
            int[,] verifica = new int[13, 3];
            int[] cartao_resposta = new int[13];
            Random gerador = new Random();
            int count = 0;

            Console.Clear();
            for (int i = 0; i < 13; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                Volta:
                    gabarito[i, z] = gerador.Next(1, 40);
                    for (int q = 0; q < 13; q++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            if (gabarito[i,z] == verifica[q,c])
                            {
                                goto Volta;
                            }
                        }
                    }
                    verifica[i, z] = gabarito[i, z];
                    Console.Write(gabarito[i, z]);
                    Console.Write("      ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            for (int z = 0; z < 13; z++)
            {
                Console.Write("Valor escolhido " + z + ": ");
                cartao_resposta[z] = int.Parse(Console.ReadLine());
                for (int c = 0; c < 3; c++)
                {
                    for (int d = 0; d < 13; d++)
                    {
                        if (gabarito[d, c] == cartao_resposta[z])
                        {
                            count++;
                            if (count == 13)
                            {
                                Console.WriteLine("VENCEDOR!");
                                break;
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}