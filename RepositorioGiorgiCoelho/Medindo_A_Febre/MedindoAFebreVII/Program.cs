using System;

namespace MedindoAFebreVII.cs
{
    internal class Program
    {
        public static Random gerador = new Random();
        public static int ajuda;

        private static void Main(string[] args)
        {
            int[] idade = new int[50];
            string[] nome = new string[50];
            char[] sexo = new char[50];
            bool[] adulto = new bool[50];
            double[] altura = new double[50];
            double porc_adulto = 0;
            double porc_nao_adulto = 0;
            double porc_masculino = 0;
            double porc_feminino = 0;
            double porc_maiores_170 = 0;
            double maisAlto = 0;
            double maisBaixo = 0;
            int maisAlto2 = 0;
            int maisBaixo2 = 0;
            int[] dezMaisVelhos = new int[50];
            double[] cincoMaisNovos = new double[5];

            for (int i = 0; i < 50; i++)
            {
                Nome(ref nome, i);
                Idade(ref idade, ref adulto, ref porc_adulto, ref porc_nao_adulto, i);
                Sexo(ref sexo, ref porc_masculino, ref porc_feminino, i);
                Altura(ref altura, ref porc_maiores_170, ref maisAlto, ref maisBaixo, i);
            }
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: {2}, Adulto: {3}", nome[i], idade[i], sexo[i], adulto[i]);
            }

            MostraResultado(ref porc_adulto, ref porc_nao_adulto, ref porc_masculino, ref porc_feminino, ref porc_maiores_170, maisAlto, maisBaixo);
            
            for (int i = 0; i < 10; i++)
            {
                for (int z = 0; z < 15; z++)
                {
                    maisAlto2 = idade[z];
                    if (idade[z] > maisAlto2)
                    {
                        dezMaisVelhos[i] = idade[z]; 
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Mais velho " + i + ":" + dezMaisVelhos[i]);
            }
            Console.ReadKey();
        }

        private static void MostraResultado(ref double porc_adulto, ref double porc_nao_adulto, ref double porc_masculino, ref double porc_feminino, ref double porc_maiores_170, double maisAlto, double maisBaixo)
        {
            FazCalculo(ref porc_adulto, ref porc_nao_adulto, ref porc_masculino, ref porc_feminino, ref porc_maiores_170);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Pessoa Mais Alta: {0:F2} | Pessoa Mais Baixa: {1:F2}", maisAlto, maisBaixo);
            Console.WriteLine("Porcentagem Adulto: {0}% | Porcentagem Não Adulto: {1}% ", porc_adulto, porc_nao_adulto);
            Console.WriteLine("Porcentagem Masculino: {0}% | Porcentagem Feminino: {1}%", porc_masculino, porc_feminino);
            Console.WriteLine("Porcentagem Maior que 1,70 Metros: {0}%", porc_maiores_170);
        }

        private static void FazCalculo(ref double porc_adulto, ref double porc_nao_adulto, ref double porc_masculino, ref double porc_feminino, ref double porc_maiores_170)
        {
            porc_adulto = (porc_adulto * 100) / 50;
            porc_feminino = (porc_feminino * 100) / 50;
            porc_maiores_170 = (porc_maiores_170 * 100) / 50;
            porc_masculino = (porc_masculino * 100) / 50;
            porc_nao_adulto = (porc_nao_adulto * 100) / 50;
        }

        private static void Altura(ref double[] altura, ref double porc_maiores_170, ref double maisAlto, ref double maisBaixo, int i)
        {
            altura[i] = gerador.NextDouble();
            altura[i] = altura[i] + 1;
            if (altura[i] > maisAlto || i == 0)
            {
                maisAlto = altura[i];
            }
            if (altura[i] < maisBaixo || i == 0)
            {
                maisBaixo = altura[i];
            }
            if (altura[i] > 1.70)
            {
                porc_maiores_170++;
            }
        }

        private static void Sexo(ref char[] sexo, ref double porc_masculino, ref double porc_feminino, int i)
        {
            ajuda = gerador.Next(0, 2);
            if (ajuda == 0)
            {
                sexo[i] = 'M';
                porc_masculino++;
            }
            else
            {
                sexo[i] = 'F';
                porc_feminino++;
            }
        }

        private static void Idade(ref int[] idade, ref bool[] adulto, ref double porc_adulto, ref double porc_nao_adulto, int i)
        {
            idade[i] = gerador.Next(0, 100);
            if (idade[i] > 17)
            {
                adulto[i] = true;
                porc_adulto++;
            }
            else
            {
                adulto[i] = false;
                porc_nao_adulto++;
            }
        }

        private static void Nome(ref string[] nome, int i)
        {
            nome[i] = "Nome" + i;
        }
    }
}