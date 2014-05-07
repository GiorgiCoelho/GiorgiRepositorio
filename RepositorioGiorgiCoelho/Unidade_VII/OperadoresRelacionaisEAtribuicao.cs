using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII
{
    class OperadoresRelacionaisEAtribuicao
    {
        public static void Main(String[] args)
        {
            int soma = 1;
            int subtracao = 1;
            int modularizacao = 1;
            double divisao = 1;
            int multiplicacao = 1;
            int incremento = 1;
            int decremento = 1;
            int incrementopre = 1;
            int decrementopre = 1;
            // Atribuição
            soma += 5;
            subtracao -= 5;
            modularizacao %= 5;
            divisao /= 5;
            multiplicacao *= 5;
            incremento++;
            decremento--;
            incremento = 1;
            decremento = 1;
            ++incrementopre;
            --decrementopre;

            Console.WriteLine("Soma: {0} ", soma);
            Console.WriteLine("Subtração: {0} ", subtracao);
            Console.WriteLine("Modularização: {0} ", modularizacao);
            Console.WriteLine("Divisão: {0} ", divisao);
            Console.WriteLine("Multiplicação: {0} ", multiplicacao);
            Console.WriteLine("Incremento ++: {0} ", incremento);
            Console.WriteLine("Decremento : {0} ", decremento);
            Console.WriteLine("Incremento ++: {0} ", incremento);
            Console.WriteLine("Decremento --: {0} ", decremento);
            Console.WriteLine("++Incremento : {0} ", incremento);
            Console.WriteLine("--Decremento : {0} ", decremento);

            //Relacionais
            Console.WriteLine(10 > 5 && 5 > 100);// Dois && verifica a primeira condição, depois a segunda
            Console.WriteLine(10 > 5 & 5 > 100);//Um & verifica as duas condições
            Console.WriteLine(10 > 5 || 5 < 100);//Dois || verifica a primeira condição, depois a segunda
            Console.WriteLine(10 > 5 | 5 < 100);//Um | verifica a primeira condição, depois a segunda
            Console.WriteLine(10 > 5 ^ 5 < 100);// ^ = OU exclusivo

            Console.ReadKey();
        }
        
        
    }
}
