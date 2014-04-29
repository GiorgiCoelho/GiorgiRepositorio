using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_GitHub_UnidadeVI
{
    class Exercício3
    {
        public static void Maini(String[] args)
        {
            string[] artigo = new string[4];
            double[] preco = new double[4];
            double[] desconto = new double[4];

            for (int i = 0; i < artigo.Length; i++)
            {
                Console.WriteLine("Nome do artigo: ");
                artigo[i] = Console.ReadLine();
                Console.WriteLine("Preco do artigo: ");
                preco[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Desconto do artigo: ");
                desconto[i] = double.Parse(Console.ReadLine());
                desconto[i] = desconto[i] / 100;
            }

            Console.Clear();

            for (int i = 0; i < artigo.Length; i++)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Nome do artigo: " + artigo[i]);
                Console.WriteLine("Preco do artigo: " + preco[i]);
                Console.WriteLine("Preço com desconto: " + (preco[i] = preco[i] - (preco[i] * desconto[i])));
                Console.WriteLine("---------------------");
            }
            Console.ReadKey();
        }
    }
}
