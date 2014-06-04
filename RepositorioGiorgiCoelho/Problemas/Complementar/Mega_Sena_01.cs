using System;

namespace Problemas.Complementar
{
    internal class Mega_Sena_01
    {
        public static void Main(string[] args)
        {
            //VARIÁVEIS
            int[] valores_megasena = new int[6];
            int[] valores_jogador = new int[6];
            int[] count = new int[6];
            int aux = 0;
            Random gerador = new Random();
            // GERA VALORES

            for (int i = 0; i < valores_megasena.Length; i++)
            {
                #region
            Volta:
                valores_megasena[i] = gerador.Next(1, 61);
                for (int z = 0; z < i; z++)
                {
                    if (valores_megasena[i] == valores_megasena[z])
                    {
                        goto Volta;
                    }
                }
            Volta2:
                Console.Clear();
                Console.Write("Digite o valor que você quer para a MEGA-SENA: ");
                valores_jogador[i] = int.Parse(Console.ReadLine());
                if (valores_jogador[i] > 60 || valores_jogador[i] <= 0)
                {
                    Console.Write("\n\nVocê escolheu um número que não há na cartela, digite qualquer tecla pra voltar!");
                    try
                    {
                        string escolha = Console.ReadLine();
                        goto Volta2;
                    }
                    catch (Exception)
                    {
                        goto Volta2;
                    }
                }

                for (int z = 0; z < i; z++)
                {
                    if (valores_jogador[i] == valores_jogador[z])
                    {
                        goto Volta2;
                    }
                }
                #endregion
            }
            Console.Clear();
            for (int i = 0; i < valores_megasena.Length; i++)
            {
                int menor = MenorValorMegaSena(valores_megasena, i);
                int menor2 = MenorValorUsuario(valores_jogador, i);
                Troca(valores_megasena, i, menor);
                Troca2(valores_jogador, i, menor2);
            }
            for (int i = 0; i < valores_megasena.Length; i++)
            {
                Console.SetCursorPosition(35, i);
                Console.Write(valores_megasena[i]);
                Console.SetCursorPosition(40, i);
                Console.Write(valores_jogador[i]);
            }
            //VERIFICAÇÃO DOS VALORES OBTIDOS

            for (int i = 0; i < valores_megasena.Length; i++)
            {
                for (int z = 0; z < valores_megasena.Length; z++)
                {
                    if (valores_jogador[z] == valores_megasena[i])
                    {
                        aux++;
                        count[aux] = valores_jogador[z];
                    }
                }
            }

            Console.WriteLine("\n\n\t\t\tQuantidade de acertos: " + aux);
            if (aux != 0)
            {
                Console.Write("\n\t\tValores acertados: ");
                for (int i = 0; i < count.Length; i++)
                {
                    if (count[i] != 0)
                    {
                        Console.Write(count[i] + " ");
                    }
                }
            }

            if (aux == 5)
            {
                Console.WriteLine("\n\n\tParabéns, você acaba de acertar na QUINA!");
            }
            else
            {
                if (aux == 6)
                    Console.WriteLine("\n\n\tParabéns, você acaba de acertar na MEGA-SENA!");
                else
                    Console.WriteLine("\n\n\tHoje não é seu dia, quem sabe na próxima você acerte na MEGA-SENA!");
            }

            Console.ReadKey();
        }

        private static void Troca2(int[] valores_jogador, int i, int menor2)
        {
            int aux = valores_jogador[i];
            valores_jogador[i] = valores_jogador[menor2];
            valores_jogador[menor2] = aux;
        }

        private static void Troca(int[] valores_megasena, int i, int menor)
        {
            int aux = valores_megasena[i];
            valores_megasena[i] = valores_megasena[menor];
            valores_megasena[menor] = aux;
        }

        private static int MenorValorUsuario(int[] valores_jogador, int i)
        {
            int menor = i;
            for (int z = i; z < valores_jogador.Length; z++)
            {
                if (valores_jogador[menor] > valores_jogador[z])
                {
                    menor = z;
                }
            }
            return menor;
        }

        private static int MenorValorMegaSena(int[] valores_megasena, int i)
        {
            int menor = i;
            for (int z = i; z < valores_megasena.Length; z++)
            {
                if (valores_megasena[menor] > valores_megasena[z])
                {
                    menor = z;
                }
            }

            return menor;
        }
    }
}