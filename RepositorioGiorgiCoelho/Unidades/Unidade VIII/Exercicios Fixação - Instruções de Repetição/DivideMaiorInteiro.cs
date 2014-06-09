using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.Exercicios_Fixação___Instruções_de_Repetição
{
    class DivideMaiorInteiro
    {
        public static void Maini(string[] args)
        {
            int variavel = 2147483647;
            int recebe = variavel;
            for (int i = 0; i < variavel; i++)
            {
                recebe = recebe / 2;
                Console.WriteLine("Valor: " +recebe);
                if (recebe < 100)
                {
                    Console.WriteLine("Quantidade de números dividos até chegar em menos que 100: " + i);                    
                    break;
                }
            }
            Console.ReadKey();
            
        }
    }
}
