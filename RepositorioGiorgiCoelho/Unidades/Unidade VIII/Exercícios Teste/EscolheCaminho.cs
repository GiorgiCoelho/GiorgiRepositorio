using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII
{
    class EscolheCaminho
    {
        public static void Maini(string[] args)
        {
            Random gerador = new Random();
            double caminho = gerador.NextDouble();
            if (caminho >= 0.5)
            {
                Console.WriteLine("Siga à direita!");
            }
            else
            {
                Console.WriteLine("Siga à esquerda!");
            }
            Console.ReadKey();
        }
    }
}
