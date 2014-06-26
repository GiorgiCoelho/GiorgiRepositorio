using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV
{
    class Exe9
    {
        public static void Maini(String[] args)
        {
            string descricao;
            int quantidade;
            double preco;
            double total;
            double desconto;
            double total_pagar;

            Console.Write("Descrição do produto: ");
            descricao = Console.ReadLine();
            Console.Write("\aQuantidade adquirida: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("\aPreço Unitário: ");
            preco = double.Parse(Console.ReadLine());
            total = quantidade * preco;

            if (quantidade <= 5)
            {
                desconto = 0.02 * total;
            }
            else if (quantidade > 5 && quantidade <= 10)
            {
                desconto = 0.03 * total;
            }
            else
            {
                desconto = 0.05 * total;
            }            
            total_pagar = total - desconto;
            Console.Clear();
            Console.WriteLine("Total: R$ "+total);
            Console.WriteLine("Desconto: R$ "+desconto);
            Console.WriteLine("Total a pagar: R$ "+total_pagar);
            Console.ReadKey();
        }
    }
}
