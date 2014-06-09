using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas
{
    class MediaElementos
    {
        public static void Maini(string[] args)
        {
            int[] array = new int[5];
            Random gerador = new Random();
            int soma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = gerador.Next(0, 11);
                Console.WriteLine("Valor "+i+": "+array[i]);
                soma += array[i];
            }

            double media = (double)soma / array.Length;
            Console.WriteLine("Média: "+media);
            Console.ReadKey();
        }
    }
}
