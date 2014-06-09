using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII
{
    class ADivididoPorB
    {
        public static void Maini(string[] args)
        {
            Random gerador = new Random();
            int a = gerador.Next(0,250);                        
            double b = gerador.Next(0,250);
            
            Console.WriteLine("Valor a: " + a);
            Console.WriteLine("Valor b: "+b);

            if (a % b == 0)
            {
                Console.WriteLine("É divisível!");
            }
            else
            {
                Console.WriteLine("Não é divisível!");
            }
            Console.ReadKey();
        }
    }
}
