using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.Exercicios_Fixação___Instruções_de_Repetição
{
    class JogoDeDado
    {
        public static void Main(String[] args)
        {
            Random gerador = new Random();
            int dado;
            int soma = 0;
            for (int i = 1; i <= 5; i++)
            {
                dado = gerador.Next(1, 7);
                soma += dado;
                if (soma > 19)
                {
                    Console.WriteLine("Você ganhou!");
                    break;
                }
            }
            Console.WriteLine("Soma: " +soma);
            if (soma <= 19)
            {
                Console.WriteLine("Perdeu!");
            }
            Console.ReadKey();
        }
    }
}
