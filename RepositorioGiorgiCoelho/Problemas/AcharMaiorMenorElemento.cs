using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas
{
    class AcharMaiorMenorElemento
    {
        static void Maini(string[] args)
        {
            int[] array = new int[5];

            Random gerador = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = gerador.Next(0, 11);
                Console.WriteLine("Valor "+i+": "+array[i]);
            }
            int maiorValor = VerificaMaior(array);
            Console.WriteLine("Maior Valor: "+array[maiorValor]);

            int menorValor = VerificaMenor(array);
            Console.WriteLine("Menor Valor: " + array[menorValor]);
            Console.ReadKey();
        }

        private static int VerificaMenor(int[] array)
        {
            int menor = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[menor] > array[i] || i == 0)
                {
                    menor = i;
                }
            }
            return menor;
        }

        private static int VerificaMaior(int[] array)
        {
            int posicaoMaior = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[posicaoMaior] < array[i])
                {
                    posicaoMaior = i;
                }
            }
            return posicaoMaior;
        }
    }
}
