using System;

namespace UnidadeVIII.Exercícios_Complementares
{
    internal class Exe1_Gerador2Numeros
    {
        public static void Maini(string[] args)
        {
            Random gerador = new Random();
            int num1 = gerador.Next(0, 11);
            int num2 = gerador.Next(0, 11);
            if (num1 > num2)
            {
                Console.WriteLine("Primeiro > Segundo");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Segundo > Primeiro"); 
            }
            else
            {
            Console.WriteLine("Primeiro = Segundo");
            }
            Console.ReadKey();
        }
    }
}