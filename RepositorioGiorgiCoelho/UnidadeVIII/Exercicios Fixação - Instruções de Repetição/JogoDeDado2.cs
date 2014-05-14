using System;

namespace UnidadeVIII.Exercicios_Fixação___Instruções_de_Repetição
{
    internal class JogoDeDado2
    {
        public static void Maini(string[] args)
        {
            int soma = 0;
            int dado;
            Random gerador = new Random();
            for (int i = 1; i <= 4; i++)
            {
                dado = gerador.Next(1, 7);
                if (dado % 2 == 0)
                {
                    continue;
                }
                soma += dado;
                if (soma > 9)
                {
                    Console.WriteLine("Venceu!");
                    Console.WriteLine("Pontos: " + soma);
                    break;
                }
            }
            if (soma <= 9)
            {
                Console.WriteLine("Perdeu!");
                Console.WriteLine("Pontos: " + soma);
            }

            Console.ReadKey();
        }
    }
}