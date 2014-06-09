using System;

namespace LivrariaHarryPotter
{
    internal class Exercicio
    {
        private static void Main(string[] args)
        {
            int quantidade_livros = 8;
            double desconto = 0;
            double preco = 42;
            int livros_repetidos = 6;

            preco = (preco * quantidade_livros);

            for (int i = 0; livros_repetidos != 0; i++)
            {
                if (livros_repetidos > 5)
                {
                    VerificaPar(ref desconto, ref livros_repetidos);
                    VerificaImpar(ref desconto, ref livros_repetidos);
                }
                if (livros_repetidos == 5)
                {
                    while ((livros_repetidos == 5))
                    {
                        livros_repetidos = livros_repetidos - 5;
                        desconto = 20 + desconto;
                    }
                }
            }

            preco = preco - ((preco * desconto) / 100);
            Console.WriteLine("O preço é: " + preco + " reais");
            Console.ReadKey();
        }

        private static void VerificaImpar(ref double desconto, ref int livros_repetidos)
        {
            if (livros_repetidos % 2 != 0)
            {
                while ((livros_repetidos % 2 != 0 && livros_repetidos > 0))
                {

                    if (livros_repetidos % 5 == 0)
                    {
                        livros_repetidos = livros_repetidos - 5;
                        desconto = 20 + desconto;
                    }
                    if (livros_repetidos % 3 == 0)
                    {
                        livros_repetidos = livros_repetidos - 3;
                        desconto = 10 + desconto;
                    }
                }
            }
        }

        private static void VerificaPar(ref double desconto, ref int livros_repetidos)
        {
            if (livros_repetidos % 2 == 0)
            {
                while ((livros_repetidos % 2 == 0 && livros_repetidos > 0))
                {
                    if (livros_repetidos % 4 == 0 && livros_repetidos > 0)
                    {
                        livros_repetidos = livros_repetidos - 4;
                        desconto = 15 + desconto;
                    }
                    if (livros_repetidos % 2 == 0 && livros_repetidos > 0)
                    {
                        livros_repetidos = livros_repetidos - 2;
                        desconto = 5 + desconto;
                    }
                }
            }
        }
    }
}