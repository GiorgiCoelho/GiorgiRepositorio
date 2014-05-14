using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.Exercícios_Complementares
{
    class Exe2_DesenhoEstrelas
    {
        public static void Maini(string[] args)
        {
            int aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int z = 1; z <= 5; z++)
                {                               
                    for (int c = 0; c < aux; c++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("**********");        
                    aux++;
                }
                aux = 0;
            }
            Console.ReadKey();
        }
    }
}
