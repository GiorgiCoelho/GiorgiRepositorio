using System;

namespace Unidade_X.cs.Exercicios_Complementares
{
    internal class Ano_Bissexto
    {
        public static void Main(string[] args)
        {
            bool verifica;
            int ano, mes, dia;
            Console.Write("Digite o ano: ");
            VerificaAnoBissexto(out ano, out verifica);
            Console.Write("Digite o dia e o mês : ");
            VerificaDataValida(ano, verifica, out mes, out dia);
            Console.ReadKey();
        }

        private static void VerificaDataValida(int recebeAno, bool recebeVerificacao, out int recebeMes, out int recebeDia)
        {
        volta:
            Console.SetCursorPosition(23, 5);
            recebeDia = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(25, 5);
            Console.WriteLine("/");
            Console.SetCursorPosition(26, 5);
            recebeMes = int.Parse(Console.ReadLine());

            if (recebeMes > 12 || recebeMes <= 0)
            {
                Console.WriteLine("Não existe esse mês, digite novamente!");
                goto volta;
            }
            else
            {
                VerificaDiaMes(recebeVerificacao, recebeMes, recebeDia, recebeAno);
            }
        }

        private static void VerificaDiaMes(bool recebeVerificacao, int recebeMes, int recebeDia,int recebeAno)
        {
            int valor = 0;
            if (recebeMes == 1)
            {
                valor = 31;
            }
            else if (recebeMes == 2)
            {
                valor = 28;
                if (recebeVerificacao == true)
                {
                    valor = 29;
                }
            }
            else if (recebeMes == 3)
            {
                valor = 31;
            }
            else if (recebeMes == 4)
            {
                valor = 30;
            }
            else if (recebeMes == 5)
            {
                valor = 31;
            }
            else if (recebeMes == 6)
            {
                valor = 30;
            }
            else if (recebeMes == 7)
            {
                valor = 31;
            }
            else if (recebeMes == 8)
            {
                valor = 31;
            }
            else if (recebeMes == 9)
            {
                valor = 30;
            }
            else if (recebeMes == 10)
            {
                valor = 31;
            }
            else if (recebeMes == 11)
            {
                valor = 30;
            }
            else if (recebeMes == 12)
            {
                valor = 31;
            }
            if (recebeDia > valor)
            {
                Console.WriteLine("\n\nDia Inválido!");
            }
            else
            {
                Console.WriteLine("\n\nDia Válido!\n\n");
                Console.WriteLine(recebeDia+"/"+recebeMes+"/"+recebeAno);
            }
            
        }

        private static void VerificaAnoBissexto(out int ano2, out bool verifica2)
        {
            ano2 = int.Parse(Console.ReadLine());
            if (ano2 % 100 != 0 && ano2 % 400 == 0 || ano2 % 4 == 0)
            {
                Console.WriteLine("\nÉ um ano bissexto!\n\n");
                verifica2 = true;
            }
            else
            {
                Console.WriteLine("\nNão é bissexto!\n\n");
                verifica2 = false;
            }
        }
    }
}