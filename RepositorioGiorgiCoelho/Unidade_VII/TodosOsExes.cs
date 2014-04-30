using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII
{
    class TodosOsExes
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int soma, sub, mult, div;
            double div2;
            string soma_string;
           
            //exe1             
            soma = a + b;
            sub = a - b;
            mult = a * b;
            div = a / b;
            //casting
            div2 = (double)a / b;
            //concatenação com string
            soma_string = "teste" + 1 + 2 + 3;
            Console.WriteLine(soma_string);
            soma_string = 1 + 2 + 3 + " teste ";


        }
    }
}
