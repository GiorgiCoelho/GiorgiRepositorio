using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixacao
{
    class Exercicio3
    {
        public static void Maini(String[] args)
        {
            int total_em_estoque;
            double valor_mercadoria;
            double media = 0;
            int i;
            Console.Write("Quantas mercadorias há em estoque? ");
            total_em_estoque = int.Parse(Console.ReadLine());
            for (i = 1; i <= total_em_estoque; i++)
            {
                Console.Clear();
                Console.Write("Preço da mercadoria ["+i+"]: R$ ");
                valor_mercadoria = double.Parse(Console.ReadLine());
                media += valor_mercadoria;
            }
            
            Console.Clear();
            Console.Write("Valor total em estoque: R$ {0}",media);
            media /= total_em_estoque;
            Console.Write("\nMédia de valor das mercadorias: R$ {0}",media);        

            Console.ReadKey();
        }
    }
}
