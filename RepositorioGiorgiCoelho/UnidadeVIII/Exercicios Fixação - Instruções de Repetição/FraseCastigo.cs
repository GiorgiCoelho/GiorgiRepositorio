using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.Exercicios_Fixação___Instruções_de_Repetição
{
    class FraseCastigo
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100;)
            {
                Console.WriteLine("Eu não andarei de skate nos corredores."); // Comando Ctrl + C faz com que o programa pare e feche.
            }
            /*int i = 1
             * while(i < 10)
             * {
             *  Console.WriteLine("Eu não andarei de skate nos corredores."); // Comando Ctrl + C faz com que o programa pare e feche.
             * } */
            Console.ReadKey();
        }
    }
}
