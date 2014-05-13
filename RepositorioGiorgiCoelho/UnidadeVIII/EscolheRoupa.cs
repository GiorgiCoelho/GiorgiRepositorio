using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII
{
    class EscolheRoupa
    {
        public static void Maini(string[] args)
        {
            Random gerador = new Random();
            double valor = gerador.NextDouble();
            if (valor >= 0.5)
            {
                Console.WriteLine("Veste camisa vermelha!");
            }
            else
            {
                Console.WriteLine("Veste camisa azul!");
            }
            Console.ReadKey();
        }
    }
}
