using System;

namespace Exercicios_Fixacao
{
    internal class Exercicio6
    {
        public static void Main(String[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int[] numero_dado = new int[101];
            Random gerador = new Random();
            for (int i = 0; i < 100; i++)
            {
                numero_dado[i] = gerador.Next(1, 7);
            }
            VerificaResultado(numero_dado,ref num1,ref num2, ref num3,ref num4,ref num5,ref num6);            

            Console.WriteLine("Quadrado 1: Caiu " + num1 + " vezes.");
            Console.WriteLine("Quadrado 2: Caiu " + num2 + " vezes.");
            Console.WriteLine("Quadrado 3: Caiu " + num3 + " vezes.");
            Console.WriteLine("Quadrado 4: Caiu " + num4 + " vezes.");
            Console.WriteLine("Quadrado 5: Caiu " + num5 + " vezes.");
            Console.WriteLine("Quadrado 6: Caiu " + num6 + " vezes.");
            Console.ReadKey();
        }

        private static void VerificaResultado(int[] a,ref int numero1,ref int numero2,ref int numero3,ref int numero4,ref int numero5,ref int numero6)
        {
            for (int i = 0; i < 100; i++)
            {
                if (a[i] == 1)
                {
                    numero1++;
                }
                if (a[i] == 2)
                {
                    numero2++;
                }
                if (a[i] == 3)
                {
                    numero3++;
                }
                if (a[i] == 4)
                {
                    numero4++;
                }
                if (a[i] == 5)
                {
                    numero5++;
                }
                if (a[i] == 6)
                {
                    numero6++;
                }
            }
        }
    }
}