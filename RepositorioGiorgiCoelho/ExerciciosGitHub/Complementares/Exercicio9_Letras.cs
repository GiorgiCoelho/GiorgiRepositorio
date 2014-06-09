using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_GitHub_Complementares_29_04_2014
{
    class Exercicio9_Letras
    {
        public static void Maini(String[] args)
        {
            int quant_buracos = 0;
            string frase;
            

            Console.WriteLine("Digite a frase: ");
            frase = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(frase = frase.ToUpper()); 
            char[] pega_letra = frase.ToCharArray();  
          
            for (int i = 0; i < frase.Length; i++)
            {
                
                if (pega_letra[i] == 'A')
                {
                    quant_buracos = quant_buracos + 1;
                }
                if (pega_letra[i] == 'B')
                {
                    quant_buracos = quant_buracos + 2;
                }
                if (pega_letra[i] == 'D')
                {
                    quant_buracos = quant_buracos + 1;
                }                
                if (pega_letra[i] == 'O')
                {
                    quant_buracos = quant_buracos + 1;
                }
                if (pega_letra[i] == 'P')
                {
                    quant_buracos = quant_buracos + 1;
                }
                if (pega_letra[i] == 'Q')
                {
                    quant_buracos = quant_buracos + 1;
                }
                if (pega_letra[i] == 'R')
                {
                    quant_buracos = quant_buracos + 1;
                }

            }
            Console.WriteLine("Quantidade de buracos: " + quant_buracos);
            Console.ReadKey();
        }
    }
}
