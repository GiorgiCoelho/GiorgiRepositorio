using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixacao
{
    class Exercicio2
    {
        public static void Main(String[] args)
        {
            double salario;
            int numero_filhos;            
            double media_salario = 0;
            double media_filhos = 0;
            int count = 0;
            double percentual_pessoas = 0;

            do
            {
                Console.Write("\aSalário: R$ ");
                salario = double.Parse(Console.ReadLine());
                if (salario < 150)
                {
                    percentual_pessoas++;   
                }
                if (salario < 0)
                {
                    goto Finish;
                }                
                Console.Write("\aNúmero de filhos: ");
                numero_filhos = int.Parse(Console.ReadLine());
                count++;
                media_salario += salario;
                media_filhos += numero_filhos;        
                
            } while (salario >= 0);
            Finish:
            Console.Clear();
            media_salario /= count;
            media_filhos /= count;
            Console.WriteLine("Média do salário: R$ {0}",media_salario);
            Console.WriteLine("Média de filhos: {0}", media_filhos);
            Console.WriteLine("Porcentual de quem ganha abaixo de R$ 150,00: {0}", percentual_pessoas);
            Console.ReadKey();            
        }
    }
}
