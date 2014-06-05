using System;

namespace Problemas
{
    internal class OrdenarElementos
    {
        public static void Maini(string[] args)
        {
            int[] array = new int[5];
            Random gerador = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = gerador.Next(0, 10);
                Console.Write(array[i] + " ");
            }

            Ordena(array);
            Console.WriteLine("");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }

        private static void Ordena(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int menor = Menor(array, i);
                MudaValor(array, i, menor);
            }
        }

        private static int Menor(int[] array, int j)
        {
            int menor = j;
            for (int i = j; i < array.Length; i++)
            {
                if (array[menor] > array[i])
                {
                    menor = i;
                }
            }
            return menor;
        }

        private static void MudaValor(int[] array, int i, int menor)
        {
            int aux = array[i];
            array[i] = array[menor];
            array[menor] = aux;
        }
    }
}