﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII
{
    class OperadoresRelacionais
    {
        public static void Main(String[] args)
        {
            int soma = 1;
            int subtracao = 1;
            int modularizacao = 1;
            int divisao = 1;
            int multiplicacao = 1;
            int incremento = 1;
            int decremento = 1;

            soma += 5;
            subtracao -= 5;
            modularizacao %= 5;
            divisao /= 5;
            multiplicacao *= 5;
            incremento++;
            decremento--;

            Console.WriteLine("Soma: {0} ", soma);
            Console.WriteLine("Subtração: {0} ", subtracao);
            Console.WriteLine("Modularização: {0} ", modularizacao);
            Console.WriteLine("Divisão: {0} ", divisao);
            Console.WriteLine("Multiplicação: {0} ", multiplicacao);
            Console.WriteLine("Incremento: {0} ", incremento);
            Console.WriteLine("Decremento: {0} ", decremento);
        }
        
        
    }
}
