using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_GitHub_UnidadeVI
{
    class Exercício1
    {
        static void Maini(string[] args)
        {
            Console.WriteLine("Digite quantos vendedores deseja-se calcular: ");
            int quant_vendedor = int.Parse(Console.ReadLine());
            double[] comissao = new double[quant_vendedor];
            string[] nomes = new string[quant_vendedor];
            double total_ganho_empresa = 0;
            double[] vendas = new double[quant_vendedor];


            for (int i = 0; i < quant_vendedor; i++)
            {

                Console.WriteLine("Digite o nome do vendedor: ");
                nomes[i] = (Console.ReadLine());

                Console.WriteLine("Digite o valor das vendas: ");
                vendas[i] = double.Parse(Console.ReadLine());

                total_ganho_empresa = (vendas[i] + total_ganho_empresa);

                if (vendas[i] > 50000)
                {
                    comissao[i] = (vendas[i] * 0.12);
                    Console.WriteLine("A comissão foi de: R$ " + comissao);
                }
                else if (vendas[i] >= 30000 && vendas[i] <= 50000)
                {
                    comissao[i] = (vendas[i] * 0.095);
                    Console.WriteLine("A comissão foi de: R$ " + comissao);
                }
                else
                {
                    comissao[i] = (vendas[i] * 0.07);
                    Console.WriteLine("A comissão foi de: R$ " + comissao);
                }

                Console.Clear();

            }




            for (int i = 0; i < quant_vendedor; i++)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Nome: " + nomes[i]);
                Console.WriteLine("Total vendido: R$ " + vendas[i]);
                Console.WriteLine("Comissão: R$ " + comissao[i]);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine(" ");
            Console.WriteLine("A empresa lucrou: R$ " + total_ganho_empresa);
            Console.ReadKey();
        }
    }
    
}
