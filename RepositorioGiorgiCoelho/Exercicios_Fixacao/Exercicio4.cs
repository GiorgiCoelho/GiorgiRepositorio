using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixacao
{
    class Exercicio4
    {
        public static void Main(String[] args)
        {
            /*
            4) 	Escreva um programa que gere todos os anagramas potenciais de uma string.
	            Por exemplo, os anagramas potenciais de "biro" são:

                                biro bior brio broi boir bori
                                ibro ibor irbo irob iobr iorb
                                rbio rboi ribo riob roib robi
                                obir obri oibr oirb orbi orib
             */

            string frase = "biro";
            char[] frase_array = frase.ToCharArray();
            string[] anagrama = new string[256];

            if (frase.Length == 1)
            {
                Console.WriteLine(frase);
            }
            else
            {
                for (int i = 0; i < frase.Length; i++)
                {                    
                    for (int z = 0; z < frase.Length; z++)
                    {
                        
                    }
                }
            }

        }
    }
}
