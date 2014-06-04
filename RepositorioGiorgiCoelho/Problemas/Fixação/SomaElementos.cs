using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas
{
    class SomaElementos
    {
        public static void Maini(string[] args)
        {
            int[] array = new int[5];
            Random gerador = new Random();
            int soma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = gerador.Next(0,11);
                soma += array[i];
                Console.WriteLine("Valor "+i+": "+array[i]);
            }
            Console.WriteLine("Soma: "+soma);
            Console.ReadKey();
        }
    }
}
