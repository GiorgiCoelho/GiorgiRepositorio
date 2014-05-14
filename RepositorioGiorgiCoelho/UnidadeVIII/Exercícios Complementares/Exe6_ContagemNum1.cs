using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.Exercícios_Complementares
{
    class Exe6_ContagemNum1
    {
        public static void Main(string[] args)
        {
            Random gerador = new Random();
            int valor = gerador.Next(0,10000);
            string valorString = valor.ToString();
            char[] valorChar = valorString.ToCharArray();
            int soma = 0;

            for (int i = 0; i < valorString.Length ; i++)
            {
                if (valorChar[i] == '1')
                {
                    soma++;   
                }
            }
            Console.WriteLine("Valor: {0}",valor);
            Console.WriteLine("Quantidade de 1 no valor: {0}", soma);
            Console.ReadKey();
        }
    }
}
