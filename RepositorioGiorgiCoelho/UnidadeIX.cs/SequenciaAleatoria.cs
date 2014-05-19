using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.cs
{
    class SequenciaAleatoria
    {
        static void Maini(string[] args)
        {
            int[] array = new int[10];
            Random gerador = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = gerador.Next(0,9999);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array ["+(i + 1)+"]:" +array[i]);
            }
            Console.ReadKey();
        }
    }
}
