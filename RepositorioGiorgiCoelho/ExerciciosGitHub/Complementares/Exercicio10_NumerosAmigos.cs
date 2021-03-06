﻿using System;

namespace Exercicios_GitHub_Complementares_29_04_2014
{
    internal class Exercicio10_NumerosAmigos
    {
        public static void Maini(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] soma1 = new int[5];
            int[] soma2 = new int[5];

            DeterminaValor(a, b);
            MetodoCalculaAmigos(a, b, soma1, soma2);
            Console.Clear();
            MetodoDeSaida(a, b, soma1, soma2);
            Console.ReadKey();

        }
        private static void MetodoDeSaida(int[] a, int[] b, int[] soma1, int[] soma2)
        {
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
        }

        private static  void MetodoCalculaAmigos(int[] a, int[] b, int[] soma1, int[] soma2)
        {
            CalculaValorA(a, soma1);
            CalculaValorB(b, soma2);
        }
        private static void CalculaValorB(int[] b,int[] soma2)
        {
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
        }
        private static void CalculaValorA(int[] a, int[] soma1)
        {
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
        }
        private static void DeterminaValor(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Valor 1 do par[" + i + "]");
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor 2 do par[" + i + "]");
                b[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}