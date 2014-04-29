using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Complementares_GitHub_UNIDADE_VI
{
    internal class Exercicio3_PesoIdeal
    {
        public static void Maini(String[] args)
        {
            /*
             3)  Tendo como entrada a altura e o sexo (codificado da seguinte forma 1:feminino 2:masculino)
                 de uma pessoa, construa um programa que calcule e imprima seu peso ideal,
                 utilizando as seguintes fórmulas:
                 - para homens : (72.7 * altura) – 58
                 - para mulheres : (62.1 * altura) – 44.7
             */

            int sexo;
            double altura;
            double peso_ideal;

            Console.WriteLine("\t ----- Bem vindo ao Medida Peso Certo v3.4(ALFA) -----");
            Console.WriteLine("\n");
            Console.Write("Sexo: Feminino(1) ou Masculino(2) - ");
            sexo = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("Digite a sua altura: ");
            altura = double.Parse(Console.ReadLine());

            if(sexo == 1)
            {
                peso_ideal = (62.1 * altura) - 44.7 ;
                Console.WriteLine("\n");
                Console.WriteLine("Peso Ideal: {0:F2}",peso_ideal);
            }
            else
            {
                peso_ideal = (72.7 * altura) - 58;
                Console.WriteLine("\n");
                Console.WriteLine("Peso Ideal: {0:F2}",peso_ideal);
            }
            Console.ReadKey();
        }
    }
}