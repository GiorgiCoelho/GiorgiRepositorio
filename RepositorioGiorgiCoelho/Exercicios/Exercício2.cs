using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_GitHub_UnidadeVI
{
    class Exercício2
    {
        public static void Maini(String[] args)
        {
            double A, B, C;
            Console.WriteLine("Valor de A: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de C: ");
            C = double.Parse(Console.ReadLine());

            if ((A + B) > C)
            {
                Console.WriteLine("Soma de A: " + A + " com B: " + B + " é maior que C: " + C);
            }
            if ((A + B) == C)
            {
                Console.WriteLine("Soma de A: " + A + " com B: " + B + " é igual a C: " + C);
            }
            if ((A + B) < C)
            {
                Console.WriteLine("Soma de A: " + A + " com B: " + B + " é menor que C: " + C);
            }
            Console.ReadKey();
        }
    }
}
