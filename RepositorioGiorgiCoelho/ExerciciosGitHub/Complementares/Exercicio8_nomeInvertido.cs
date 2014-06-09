using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_GitHub_Complementares_29_04_2014
{
    class Exercicio8_nomeInvertido
    {
        public static void Maini(String[] args)
        {
            string nome, sobrenome;
            char primeira_letra;
            int quant_nomes;

            Console.WriteLine("Quantidade de nomes: ");
            quant_nomes = int.Parse(Console.ReadLine());
            string[] guarda_nomes = new string[quant_nomes];
            for (int i = 0; i < quant_nomes; i++)
            {
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();
                primeira_letra = char.ToUpper(nome[0]);
                Console.WriteLine("Sobrenome: ");
                sobrenome = Console.ReadLine();
                sobrenome = sobrenome.ToUpper();
                guarda_nomes[i] = sobrenome + ", " + (primeira_letra + nome.Substring(1));
            }
            for (int i = 0; i < quant_nomes; i++)
            {
                Console.WriteLine(guarda_nomes[i]);
            }

            Console.ReadKey();
        }
    }
}
