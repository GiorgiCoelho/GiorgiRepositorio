using System;

namespace UnidadeVIII.Exercícios_Complementares
{
    internal class Exe5_Dado
    {
        public static void Maini(string[] args)
        {
            int soma = 0;
            int num_seis = 0;
            Random gerador = new Random();
            int dado;
            for (int i = 1; i <= 10; i++)
            {
                dado = gerador.Next(1, 7);
                Console.WriteLine("Valor [{0}]: {1}", i, dado);
                if (dado != 1)
                {
                    soma += dado;
                }
                if (dado == 6)
                {
                    num_seis++;
                    if (num_seis == 2)
                    {
                        goto Finish2;
                    }
                }
            }

            if (soma % 2 != 0)
            {
                Console.WriteLine("Valor da soma: " + soma);
                Console.WriteLine("Você ganhou!");
                goto Final;
            }
            else
            {
                goto Finish;
            }

        Finish:
            Console.WriteLine("Valor da soma: " + soma);
            Console.WriteLine("Você perdeu!");
            goto Final;
        Finish2:
            Console.WriteLine("Perdeu! Caiu 2x no valor 6!");
        Final:
            Console.ReadKey();
        }
    }
}