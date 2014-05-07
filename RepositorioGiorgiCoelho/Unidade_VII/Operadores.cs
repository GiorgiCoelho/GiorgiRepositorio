using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII
{
    class Operadores
    {
        public static void Main(String[] args)
        {
            int a = 0;
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
            Console.WriteLine(soma_string2);          

        
        }
    }
}
