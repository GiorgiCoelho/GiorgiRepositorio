using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.cs
{
    class Tabuada
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de linhas: ");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de colunas: ");
            int coluna = int.Parse(Console.ReadLine());

            int[,] array = new int[linha + 1, coluna + 1];

            for (int i = 1; i <= linha; i++)
            {            
                for (int z = 1; z <= coluna; z++)
                {
                    array[i, z] = i * z;
                }
            }
            for (int i = 1; i <= linha; i++)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Tabuada do "+i);
                Console.WriteLine("----------------------");
               for (int z = 1; z <= coluna; z++)
                {
                    Console.WriteLine("Valor [" + i + "," + z + "] :" + array[i, z]);  
                } 
            }
            Console.ReadKey();
        }
    }
}
