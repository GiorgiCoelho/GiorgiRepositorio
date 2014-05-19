using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.cs
{
    class SequenciaCrescente
    {
        public static void Maini(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                if (i >= 1)
                {
                    Console.WriteLine("Digite um valor maior que o anterior: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Digite um valor: ");
                    array[i] = int.Parse(Console.ReadLine());
                }                
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array [" + (i + 1) + "]:" + array[i]);
            }
            Console.ReadKey();
        }
    }
}
