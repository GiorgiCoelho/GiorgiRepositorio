using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_X.cs
{
    class ConsumoDeCombustivel
    {
        static void Maini(string[] args)
        {
            double km_andado;
            double litros_carro;
            double Km_L;

            Console.WriteLine("Quantos litros foram colocados no carro?");
            litros_carro = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos km foram andados?");
            km_andado = double.Parse(Console.ReadLine());
            Km_L = CalculoKm(litros_carro, km_andado);
            Console.WriteLine("Km/L: {0:F2}",Km_L);
            Console.ReadKey();
        }

        private static double CalculoKm(double x, double y)
        {
            double calculo = y / x;
            return calculo;
        }
    }
}
