﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.Exercicios_Fixação___Instruções_de_Repetição
{
    class Imprime100
    {
        public static void Maini(string[] args)
        {
            for (int i = 1; i <= 100 ; i++)
            {
                Console.WriteLine("Número: "+i);
            }
            Console.ReadKey();
        }   
    }
}
