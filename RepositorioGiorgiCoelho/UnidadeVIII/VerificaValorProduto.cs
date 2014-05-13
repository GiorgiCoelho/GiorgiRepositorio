using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII
{
    class VerificaValorProduto
    {
        public static void Maini(string[] args)
        {
            Random gerador = new Random();
            double valor = gerador.NextDouble();
            if (valor >= 0.5)
            {                
                Console.WriteLine("Preço está caro!");
                Console.WriteLine("Preço: R$ " + (valor * 100).ToString("##.##"));
            }
            else
            {
                Console.WriteLine("Preço está em conta!");
                Console.WriteLine("Preço: R$ " + (valor * 100).ToString("##.##"));
            }
            Console.ReadKey();
        }
    }
}
