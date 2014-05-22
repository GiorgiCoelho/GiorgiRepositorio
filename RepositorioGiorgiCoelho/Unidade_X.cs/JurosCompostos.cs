using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_X.cs
{
    class JurosCompostos
    {
        public static void Maini(string[] args)
        {
            double montante;
            double capital;
            double taxa_juros;
            double tempo_aplicacao;

            Console.WriteLine("Capital: ");
            capital = double.Parse(Console.ReadLine());
            Console.WriteLine("Tempo: ");
            tempo_aplicacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Taxa de Juros: ");
            taxa_juros = double.Parse(Console.ReadLine());
            taxa_juros = taxa_juros / 100;

            montante = CalculaMontante(capital, tempo_aplicacao, taxa_juros);
            Console.WriteLine("Montante: {0:F2}",montante);
            Console.ReadKey();
        }

        private static double CalculaMontante(double a, double b, double c)
        {
            double calculo = a * Math.Pow((1 + c),b);
            return calculo;
        }

    }
}
