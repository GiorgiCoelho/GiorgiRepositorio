using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Complementares_GitHub_UNIDADE_VI
{
    class Exercicio1_Maca
    {
        static void Main(string[] args)
        {
            /*
               1) As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, 
               e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, 
               calcule e escreva o valor total da compra.
            */

            int quantidade_macas;
            double valor_total_compra;

            Console.WriteLine("\t ----- Bem vindo à fruteira v1.0 -----" );
            Console.WriteLine("\n");
            Console.Write("Quantas maçãs você deseja comprar? ");
            quantidade_macas = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (quantidade_macas >= 12)
            {
                valor_total_compra = quantidade_macas * 0.30;
                Console.Write("Valor total de compra foi de R$ {0}",valor_total_compra);
            }
            else
            {
                valor_total_compra = quantidade_macas * 0.25;
                Console.Write("Valor total de compra foi de R$ {0}",valor_total_compra);
            }
            Console.ReadKey();
        }
    }
}
