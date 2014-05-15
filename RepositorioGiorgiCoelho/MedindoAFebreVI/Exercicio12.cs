using System;

namespace MedindoAFebreVI
{
    internal class Exercicio12
    {
        private static void Main(string[] args)
        {
            double[] notas = new double[3];
            double[] media = new double[100];
            double[] soma_nota = new double[100];
            int[] num_aulas_faltadas = new int[100];
            int[] num_matricula = new int[100];
            int num_aulas;
            double maior_nota = 0;
            double menor_nota = 11;
            double nota_media_turma;
            double soma_medias = 0;
            int[] frequencia = new int[100];
            int[] verifica = new int[100];
            
            do
            {
                Console.WriteLine("Quantas aulas teve no semestre? Deve ter maior que 40 aulas! ");
                num_aulas = int.Parse(Console.ReadLine());
            } while (num_aulas < 40);

            for (int i = 0; i < 100; i++)
            {
                for (int q = 0; q <= i; q++)
                {
                    Console.WriteLine("Matrícula do aluno: ");
                    num_matricula[q] = int.Parse(Console.ReadLine());
                }

                for (int c = 0; c < 3; c++)
                {
                    do
                    {
                        Console.WriteLine("Nota " + c + ":");
                        notas[c] = double.Parse(Console.ReadLine());
                        if (notas[c] > 10 || notas[c] < 0)
                        {
                            Console.WriteLine("Digite novamente a nota, há algum erro!");
                        }
                    } while (notas[c] > 10 || notas[c] < 0);
                    soma_nota[i] += notas[c];
                }
                Console.Clear();
                soma_nota[i] = soma_nota[i] / 3;
                if (soma_nota[i] > maior_nota)
                {
                    maior_nota = soma_nota[i];
                }
                if (soma_nota[i] < menor_nota)
                {
                    menor_nota = soma_nota[i];
                }

                Console.WriteLine("Quantas faltas esse aluno teve? ");
                num_aulas_faltadas[i] = int.Parse(Console.ReadLine());
                soma_medias += soma_nota[i];
                frequencia[i] = num_aulas - num_aulas_faltadas[i];
            }
            nota_media_turma = (soma_medias / 100);

            int aprovados = 0;
            int reprovados = 0;
            Console.WriteLine("Média da turma: " + nota_media_turma);
            Console.WriteLine("Alunos: 100");
            for (int i = 0; i < 100; i++)
            {
                for (int z = 0; z < 100; z++)
                {
                    if (soma_nota[z] >= 6 && frequencia[z] >= 40)
                    {
                        aprovados++;
                    }
                    if (soma_nota[z] < 6)
                    {
                        reprovados++;
                    }
                    if (frequencia[z] < 40)
                    {
                        reprovados++;
                    }
                }
                Console.WriteLine("Alunos aprovados: " + aprovados);
                for (int x = 0; x < aprovados; x++)
                {
                    Console.WriteLine("Aluno " + i);
                    Console.WriteLine("Número da matrícula: " + num_matricula[i]);
                    Console.WriteLine("Nota Final: " + soma_nota[i]);
                    Console.WriteLine("Frequência: " + frequencia[i] + " aulas.");
                }
                Console.WriteLine("Alunos Reprovados: " + reprovados);
                for (int g = 0; g < reprovados; g++)
                {
                    Console.WriteLine("Aluno " + i);
                    Console.WriteLine("Número da matrícula: " + num_matricula[i]);
                    Console.WriteLine("Nota Final: " + soma_nota[i]);
                    Console.WriteLine("Frequência: " + frequencia[i] + " aulas.");
                }
            }

            Console.ReadKey();
        }
    }
}