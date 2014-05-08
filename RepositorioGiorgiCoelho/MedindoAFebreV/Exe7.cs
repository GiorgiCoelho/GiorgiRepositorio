using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV
{
    class Exe7
    {
        static void Maini(string[] args)
        {        
        
            int idade;
            Console.WriteLine("Idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine(idade > 20 ? "Adulto" : "Não é adulto");
            Console.ReadKey();       
        }
    }
}
