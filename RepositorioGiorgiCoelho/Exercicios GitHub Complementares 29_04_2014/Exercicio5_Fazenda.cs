using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Complementares_GitHub_UNIDADE_VI
{
    class Exercicio5_Fazenda
    {
        public static void Main(String[] args)
        {
            int quantidade_trabalhadores;

            int[] numero_trabalhador;
            int[] idade;
            int[] quantidade_caixas;
            double[] trabalhador_ganhou;

            InicioDoPrograma(out quantidade_trabalhadores, out numero_trabalhador, out idade, out quantidade_caixas, out trabalhador_ganhou);

            for (int i = 0; i < quantidade_trabalhadores; i++)
            {
                Identidade_Idade_Caixas_Do_Trabalhador(numero_trabalhador, idade, quantidade_caixas, i);
                ValidaCaixas(idade, quantidade_caixas, trabalhador_ganhou, i);
            }

            for (int i = 0; i < quantidade_trabalhadores; i++)
            {
                Console.Clear();
                SaidaDeDados(numero_trabalhador, quantidade_caixas, trabalhador_ganhou, i);
            }

            Console.ReadKey();
        }

        private static void SaidaDeDados(int[] numero_trabalhador, int[] quantidade_caixas, double[] trabalhador_ganhou, int i)
        {
            Console.WriteLine("Trabalhador {0} recebeu R$ {1} por pegar {2} caixas.", numero_trabalhador[i], trabalhador_ganhou[i], quantidade_caixas[i]);
        }

        private static void ValidaCaixas(int[] idade, int[] quantidade_caixas, double[] trabalhador_ganhou, int i)
        {
            if (quantidade_caixas[i] <= 5)
            {
                if (idade[i] >= 18 && idade[i] < 45)
                {
                    trabalhador_ganhou[i] = (quantidade_caixas[i] * 2) + ((quantidade_caixas[i] * 2) * 0.1);
                }
                else if (idade[i] >= 45 && idade[i] <= 65)
                {
                    trabalhador_ganhou[i] = (quantidade_caixas[i] * 2) + ((quantidade_caixas[i] * 2) * 0.2);
                }
            }
            else if (quantidade_caixas[i] > 5 && quantidade_caixas[i] <= 10)
            {
                if (idade[i] >= 18 && idade[i] < 45)
                {
                    trabalhador_ganhou[i] = (quantidade_caixas[i] * 2.50) + ((quantidade_caixas[i] * 2.50) * 0.1);
                }
                else if (idade[i] >= 45 && idade[i] <= 65)
                {
                    trabalhador_ganhou[i] = (quantidade_caixas[i] * 2.50) + ((quantidade_caixas[i] * 2.50) * 0.2);
                }
            }
            else if (quantidade_caixas[i] > 10 && quantidade_caixas[i] <= 20)
            {
                if (idade[i] >= 18 && idade[i] < 45)
                {
                    trabalhador_ganhou[i] = (quantidade_caixas[i] * 3.50) + ((quantidade_caixas[i] * 3.50) * 0.1);
                }
                else if (idade[i] >= 45 && idade[i] <= 65)
                {
                    trabalhador_ganhou[i] = (quantidade_caixas[i] * 3.50) + ((quantidade_caixas[i] * 3.50) * 0.2);
                }
            }
            else
            {
                if (idade[i] >= 18 && idade[i] < 45)
                {
                    trabalhador_ganhou[i] = (quantidade_caixas[i] * 5) + ((quantidade_caixas[i] * 5) * 0.1);
                }
                else if (idade[i] >= 45 && idade[i] <= 65)
                {
                    trabalhador_ganhou[i] = (quantidade_caixas[i] * 5) + ((quantidade_caixas[i] * 5) * 0.2);
                }
            }
        }

        private static void Identidade_Idade_Caixas_Do_Trabalhador(int[] numero_trabalhador, int[] idade, int[] quantidade_caixas, int i)
        {
            Console.Clear();
            Console.Write("Qual o número desse trabalhador? ");
            numero_trabalhador[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("\a");
            do
            {
                Console.Write("Qual a idade desse trabalhador? ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (idade[i] < 18 || idade[i] > 65);

            Console.WriteLine("\a");
            Console.Write("Quantas caixas de laranja ele pegou no dia? ");
            quantidade_caixas[i] = int.Parse(Console.ReadLine());
        }

        private static void InicioDoPrograma(out int quantidade_trabalhadores, out int[] numero_trabalhador, out int[] idade, out int[] quantidade_caixas, out double[] trabalhador_ganhou)
        {
            Console.WriteLine("\t Bem vindo à FarmVille v2.1 ");
            Console.WriteLine("\a");
            Console.Write("Quantidade de trabalhadores que deseja cadastrar: ");
            quantidade_trabalhadores = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            numero_trabalhador = new int[quantidade_trabalhadores];
            idade = new int[quantidade_trabalhadores];
            quantidade_caixas = new int[quantidade_trabalhadores];
            trabalhador_ganhou = new double[quantidade_trabalhadores];
        }
    }
}
