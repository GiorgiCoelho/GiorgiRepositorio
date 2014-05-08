using System;

namespace Exercicios_Fixacao
{
    internal class Exercicio1
    {
        private static void Maini(string[] args)
        {
            double preco_produto;
            double maior_preco = 0;
            double soma_valores = 0;
            double media;
            int codigo;

            for (int i = 0; i < 15; i++)
            {
                Console.Write("\a\nCódigo do produto ["+i+"]: ");
                codigo = int.Parse(Console.ReadLine());
                Console.Write("\nPreço do produto [" + i + "]: R$ ");
                preco_produto = double.Parse(Console.ReadLine());
                if (preco_produto > maior_preco)
                {
                    maior_preco = preco_produto;
                }
                soma_valores += preco_produto;
            }
            media = soma_valores / 15;
            Console.Clear();
            Console.WriteLine("\tMédia: R$ {0}", media); 
            Console.WriteLine("\tValor mais alto: R$ {0}", maior_preco);
            Console.ReadKey();
        }
    }
}