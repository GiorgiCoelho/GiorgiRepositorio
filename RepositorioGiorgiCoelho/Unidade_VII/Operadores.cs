using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII
{
    class Operadores
    {
        public static void Maini(String[] args)
        {
            //Operadores

            /*int a = 0;
            int b = 0;
            int soma, sub, mult, div;
            int divCast;
            string soma_string, soma_string2;

            //exe2             
            soma = a + b;
            sub = a - b;
            mult = a * b;
            div = a / b;
            //exe3
            divCast = (int)a / b;            
            //exe4
            soma_string = "teste" + 1 + 2 + 3;
            Console.WriteLine(soma_string);            
            soma_string2 = " teste " + 1 + 2 + 3;
            Console.WriteLine(soma_string2);*/
            Operador();        
        }

        private static void Operador()
        {
            //Variáveis
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
            Atribuicao(ref soma, ref subtracao, ref modularizacao, ref divisao, ref multiplicacao);
            // incremento e decremento
            IncrementoDecremento(ref incremento, ref decremento, ref incrementopre, ref decrementopre);
            //Operador Ternário
            Ternario(ref soma);
            //Saída de dados
            SaidaDados(soma, subtracao, modularizacao, divisao, multiplicacao, incremento, decremento);
            //Relacionais
            Relacionais();
        }

        private static void Relacionais()
        {
            Console.WriteLine(10 > 5 && 5 > 100);// Dois && verifica a primeira condição, depois a segunda
            Console.WriteLine(10 > 5 & 5 > 100);//Um & verifica as duas condições
            Console.WriteLine(10 > 5 || 5 < 100);//Dois || verifica a primeira condição, depois a segunda
            Console.WriteLine(10 > 5 | 5 < 100);//Um | verifica a primeira condição, depois a segunda
            Console.WriteLine(10 > 5 ^ 5 < 100);// ^ = OU exclusivo
        }             

        private static void SaidaDados(int soma, int subtracao, int modularizacao, double divisao, int multiplicacao, int incremento, int decremento)
        {
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
        }

        private static void Ternario(ref int soma)
        {
            Console.WriteLine(soma >= 5 ? "Soma é maior que 5!" : "Soma não é maior que 5!"); 
        }

        private static void IncrementoDecremento(ref int incremento, ref int decremento, ref int incrementopre, ref int decrementopre)
        {
            incremento++;//pos incremento
            decremento--;//pos decremento
            incremento = 1;
            decremento = 1;
            ++incrementopre;//pre incremento
            --decrementopre;//pre decremento
        }

        private static void Atribuicao(ref int soma, ref int subtracao, ref int modularizacao, ref double divisao, ref int multiplicacao)
        {
            soma += 5;
            subtracao -= 5;
            modularizacao %= 5;
            divisao /= 5;
            multiplicacao *= 5;
        }
    }
}
