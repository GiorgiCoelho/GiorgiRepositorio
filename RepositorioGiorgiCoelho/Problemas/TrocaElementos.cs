using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas
{
    class TrocaElementos
    {
        public static void Maini(string[] args)
        {
            int[] array = new int[5];
            Random gerador = new Random();
            Console.Write("Valores: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = gerador.Next(0, 11);                
                Console.Write(array[i]+" ");
            }
            Random geraValorTroca = new Random();
            int aux2 = geraValorTroca.Next(0, 5);
            int aux3 = 0;
            do
            {
                aux3 = geraValorTroca.Next(0, 5); 
 
            } while (aux3 == aux2);

            int aux = array[aux2];
            array[aux2] = array[aux3];
            array[aux3] = aux;

            Console.Write("\nValores Trocados: ");
            for (int i = 0; i < array.Length; i++)
            {                           
                Console.Write(array[i]+" ");
            }
            Console.ReadKey();


        }
    }
}
