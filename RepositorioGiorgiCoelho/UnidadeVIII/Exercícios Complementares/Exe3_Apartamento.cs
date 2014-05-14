using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.Exercícios_Complementares
{
    class Exe3_Apartamento
    {
        public static void Maini(string[] args)
        {
            
            for (int i = 1; i <= 3; i++)
            {
                int soma = 10;
                Console.WriteLine("\n**********************\a");
                Console.WriteLine("\nBloco: " +i);
                for (int z = 1; z <= 9; z++)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Andar: "+z);
                    for (int c = 1; c <= 4; c++)
                    {
                        soma++;
                        Console.WriteLine("Apartamento: "+ soma);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
