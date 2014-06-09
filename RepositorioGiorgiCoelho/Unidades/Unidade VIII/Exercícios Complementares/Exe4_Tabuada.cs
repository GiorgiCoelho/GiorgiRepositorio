using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.Exercícios_Complementares
{
    class Exe4_Tabuada
    {
        public static void Maini(string[] args)
        {
            int resultado;

            for (int i = 1; i <= 10; i++)
            {
                for (int z = 1; z <= 10; z++)
                {
                    resultado = i * z;
                    Console.WriteLine(i+ " X " +z+ " = " + resultado);
                }
                Console.WriteLine("--------------------------");
            }
            Console.ReadKey();
        }
    }
}
