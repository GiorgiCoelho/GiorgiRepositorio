using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.cs
{
    internal class SequenciaImpar
    {
        public static void Maini(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                do
                {
                    Console.WriteLine("Digite um número que seja ímpar: ");
                    array[i] = int.Parse(Console.ReadLine());
                } while (array[i] % 2 == 0);
            }  
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array [" + (i + 1) + "]:" + array[i]);
            }
            Console.ReadKey();
        }
    }
}