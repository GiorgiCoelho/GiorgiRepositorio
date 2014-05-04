using System;

namespace Exercicios_GitHub_Complementares_29_04_2014
{
    internal class Exercicio10_NumerosAmigos
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] soma1 = new int[5];
            int[] soma2 = new int[5];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Valor 1 do par["+i+"]");
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor 2 do par[" + i + "]");
                b[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                int valor = a[i];
                for (int z = 0; z < valor; z++)
                {
                    if (z != 0 && a[i] % z == 0)
                    {
                        soma1[i] = soma1[i] + z;
                    }                    
                }

            }
            for (int i = 0; i < b.Length; i++)
            {
                int valor = b[i];
                for (int z = 0; z < valor; z++)
                {
                    if (z != 0 && b[i] % z == 0)
                    {
                        soma2[i] = soma2[i] + z;
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                if (soma1[i] == b[i] && soma2[i] == a[i])
                {
                    Console.WriteLine(a[i] + " e " + b[i] + " São amigos!");
                }
                else
                {
                    Console.WriteLine(a[i] + " e " + b[i] + " Não são amigos");
                }
            }
            Console.ReadKey();

        }
    }
}