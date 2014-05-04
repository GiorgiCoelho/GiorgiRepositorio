using System;

namespace Exercicios_Complementares_GitHub_UNIDADE_VI
{
    internal class Exercicio6_Concurso_de_Beleza
    {
        public static void Maini(String[] args)
        {
            string nome_moca;
            double altura_moca;
            double moca_mais_alta = 0;
            string nome_moca_mais_alta = "";


            do
            {
                Console.Clear();
                Console.Write("Nome da moça: ");
                nome_moca = Console.ReadLine();
                if (nome_moca == "FIM")
                {
                    break;
                    
                }                
                Console.WriteLine("\a");
                Console.Write("Altura da moça: ");
                altura_moca = double.Parse(Console.ReadLine());           
               

                if (altura_moca > moca_mais_alta)
                {
                    moca_mais_alta = altura_moca;
                    nome_moca_mais_alta = nome_moca;
                }
               
            }
            while (nome_moca != "FIM");

            Console.WriteLine("{0} é a moça mais alta, com {1} metros de altura!",nome_moca_mais_alta,moca_mais_alta);
            Console.ReadKey();
        }
    }
}