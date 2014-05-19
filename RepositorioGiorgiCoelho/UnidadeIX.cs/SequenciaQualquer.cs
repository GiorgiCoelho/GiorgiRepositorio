using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.cs
{
    class SequenciaQualquer
    {
        public static void Maini(string[] args)
        {
            int[] array = new int[10];
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Digite um valor: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array [" + (i + 1) + "]:" + array[i]);
            }
            Console.ReadKey();
        }
    }
}
