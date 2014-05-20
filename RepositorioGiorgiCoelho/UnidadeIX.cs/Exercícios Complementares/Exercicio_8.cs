using System;

namespace UnidadeIX.cs
{
    internal class Exercicio_8
    {
        public static void Maini(string[] args)
        {
            int[] gabarito = new int[13];

            int quant_jogadores;
            Console.Write("Quantidade de jogadores? ");
            quant_jogadores = int.Parse(Console.ReadLine());
            int[] jogador = new int[quant_jogadores];
            int count = 0;
            Random gerador = new Random();

            for (int i = 0; i < 13; i++)
            {
                gabarito[i] = gerador.Next(1, 4);
                Console.WriteLine(gabarito[i]);
            }
            for (int i = 0; i < quant_jogadores; i++)
            {
                for (int z = 0; z < 13; z++)
                {
                   
                    Console.Write("Jogou qual número? ");
                    jogador[i] = int.Parse(Console.ReadLine());
                    if (jogador[i] == gabarito[z])
                    {
                        ++count;
                        if (count == 13)
                        {
                            Console.WriteLine("Jogador "+(i+1)+" foi GANHADOR!");
                            Console.WriteLine("-------------------------------");
                            Console.ReadKey();                            
                        }
                    }                   
                }
                Console.Clear(); 
            }
            Console.ReadKey();
        }
    }
}