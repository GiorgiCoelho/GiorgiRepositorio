using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.cs
{
    class TabelaAleatoria
    {
        public static void Maini(string[] args)
        {
            Console.WriteLine("Quantidade de linhas: ");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de colunas: ");
            int coluna = int.Parse(Console.ReadLine());
            Random gerador = new Random();

            int[,] array = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                for (int z = 0; z < coluna; z++)
                {
                    array[i, z] = gerador.Next(0, 999);
                }
            }
            Console.Clear();
            for (int i = 0; i < linha; i++)
            {
                for (int z = 0; z < coluna; z++)
                {
                    Console.WriteLine("Valor [" + i + "," + z + "] :" + array[i, z]);
                }
            }
            Console.ReadKey();
        }
    }
}
