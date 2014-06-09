using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_X.cs
{
    class IMC
    {
        public static void Maini(string[] args)
        {
            double IMC;
            double peso;
            double altura;

            Console.WriteLine("Seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Sua altura: ");
            altura = double.Parse(Console.ReadLine());
            IMC = CalculaIMC(peso, altura);
            Console.WriteLine("IMC: "+IMC);
            VerificaCondicao(IMC);
            Console.ReadKey();
        }

        private static void VerificaCondicao(double IMC)
        {
            if (IMC < 18.5)
            {
                Console.WriteLine("Situação : Você está abaixo do peso ideal");
            }
            if (IMC < 24.9)
            {
                Console.WriteLine("Situação : Você está no peso ideal");
            }
            if (IMC < 29.9)
            {
                Console.WriteLine("Situação : Você está acima do seu peso(Sobrepeso)");
            }
            if (IMC < 34.9)
            {
                Console.WriteLine("Situação : Sobrepeso I");
            }
            if (IMC < 39.9)
            {
                Console.WriteLine("Situação : Sobrepeso II");
            }
            if (IMC >= 40)
            {
                Console.WriteLine("Situação : Sobrepeso III");
            }
        }

        private static double CalculaIMC(double peso, double altura)
        {
            double IMC;
            IMC = peso / Math.Pow(altura, 2);
            return IMC;
        }
    }
}
