using System;

namespace UnidadeVIII
{
    internal class AprovadoReprovado
    {
        private static void Maini(string[] args)
        {
            Random gerador = new Random();
            double nota = gerador.NextDouble();
            nota = nota * 10;
            if (nota >= 7)
            {
                Console.WriteLine("Aluno Aprovado!");
                Console.WriteLine("Nota: {0}", nota.ToString("##.##"));
            }
            else
            {
                Console.WriteLine("Aluno Reprovado!");
                Console.WriteLine("Nota: {0}", nota.ToString("##.##"));                
            }

            Console.ReadKey();
        }
    }
}