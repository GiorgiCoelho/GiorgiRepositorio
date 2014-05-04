using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_GitHub_Complementares_29_04_2014
{
    class Exercicio7_Funcionario
    {
        public static void Maini(String[] args)
        {
            /*
             * 7)	Escreva um programa que leia dados o tipo do funcionário (“H” = Horista ou “M” = Mensalista), 
             * o salário por hora (horistas) ou por mês (mensalistas) e, o número de horas trabalhadas (horistas)
             * ou o valor de faltas (mensalistas), calcular o valor do salário bruto.
            */

            string tipo_funcionario;
            double salario_hora;
            double salario_mes;
            int horas_trabalhadas;
            int faltas;
            double salario_bruto;
            double valor_falta;

            Console.Write(@"Tipo do funcionário: 'H'(HORISTA) - 'M'(MENSALISTA) -> ");
            tipo_funcionario = Console.ReadLine();

            if (tipo_funcionario.ToUpper() == "H")
            {
                Console.WriteLine("\a");
                Console.Write("Salário por hora? ");
                salario_hora = double.Parse(Console.ReadLine());
                Console.Write("Horas trabalhadas? ");
                horas_trabalhadas = int.Parse(Console.ReadLine());

                salario_bruto = horas_trabalhadas * salario_hora;
                Console.WriteLine("Salário bruto: " + salario_bruto);
            }
            if (tipo_funcionario.ToUpper() == "M")
            {
                Console.WriteLine("\a");
                Console.Write("Salário por mês? ");
                salario_mes = double.Parse(Console.ReadLine());
                Console.Write("Quantas faltas? ");
                faltas = int.Parse(Console.ReadLine());
                Console.Write("Qual o valor da falta? ");
                valor_falta = double.Parse(Console.ReadLine());

                salario_bruto = salario_mes - (faltas * valor_falta);
                Console.WriteLine("Salário bruto: " + salario_bruto);
            }
            Console.ReadKey();
        }
    }
}
