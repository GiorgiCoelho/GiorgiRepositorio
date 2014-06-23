using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Unidades.Collections
{
    internal class Collection
    {
        /*
        public static void Main(string[] args)
        {
            ArrayList questoes = new ArrayList();
            Random gerador = new Random();

            for (int i = 0; i < 10; i++)
            {
                questoes.Add(gerador.Next(1, 4));
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Questão [" + (i + 1) + "]: " + questoes[i]);
                Console.WriteLine("-----------------------------");
            }
        }
         */

        /* public static void Main(string[] args)
         {
             ArrayList numeros = new ArrayList();

             for (int i = 0; i < 10; i++)
             {
                 if (i >= 1)
                 {
                     Console.WriteLine("Digite um valor menor que o anterior: ");
                     numeros.Add(Console.ReadLine());
                 }
                 else
                 {
                     Console.WriteLine("Digite um valor: ");
                     numeros.Add(Console.ReadLine());
                 }
             }
             for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine("Lista [" +(i+1)+"]: " +numeros[i]);
             }
         }*/

        public static void Main(string[] args)
        {
            ArrayList artigo = new ArrayList();
            ArrayList preco = new ArrayList();
            ArrayList desconto = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome do artigo: ");
                artigo.Add(Console.ReadLine()); 
                Console.WriteLine("Preco do artigo: ");
                preco.Add(double.Parse(Console.ReadLine()));
                Console.WriteLine("Desconto do artigo: ");
                desconto.Add(double.Parse(Console.ReadLine()));
                desconto[i] = ((double)desconto[i] / 100);
            }
            Console.ReadKey();
        }


    }
}