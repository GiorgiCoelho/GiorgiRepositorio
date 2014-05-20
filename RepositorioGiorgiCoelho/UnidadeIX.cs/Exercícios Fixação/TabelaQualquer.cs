using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.cs
{
    class TabelaQualquer
    {
        public static void Maini(string[] args)
        {
            Console.WriteLine("Quantidade de linhas: ");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de colunas: ");
            int coluna = int.Parse(Console.ReadLine());

            int[,] array = new int[linha, coluna];
            for (int i = 0; i < linha; i++)
            {                
                for (int z = 0; z < coluna; z++)
                {
                    Console.Write("Dê um valor: ");
                    array[i, z] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            for (int i = 0; i < linha; i++)
            {
                for (int z = 0; z < coluna; z++)
                {
                    Console.WriteLine("Valor ["+i+","+z+"] :"+array[i,z]);                    
                }
            }
            Console.ReadKey();
        }
    }
}
