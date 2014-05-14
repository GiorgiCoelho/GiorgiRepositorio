using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.Exercicios_Fixação___Instruções_de_Repetição
{
    class GeradorDeIngressos
    {
        public static void Maini(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int z = 1; z < 21; z++)
                {
                    Console.WriteLine("Setor " +i+ " - Lugar: " +z);
                }
                Console.WriteLine("------------------------");
            }
            Console.ReadKey();
        }
    }
}
