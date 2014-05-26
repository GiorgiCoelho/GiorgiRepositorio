using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_X.cs
{
    class Arrays
    {
        public static void Maini(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            array2 = PreencheArray(array1);
            MostraArray(array2);
            Console.ReadKey();
        }

        private static void MostraArray(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Array "+i+": "+x[i] );
            }
        }

        private static int[] PreencheArray(int[] x)
        {
            Random gerador = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = gerador.Next(0,100);
            }
            return x;            
        }
    }
}
