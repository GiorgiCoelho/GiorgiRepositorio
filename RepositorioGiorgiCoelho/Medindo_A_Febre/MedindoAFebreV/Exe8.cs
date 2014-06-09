using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV
{
    class Exe8
    {
        public static void Maini(String[] args)
        {
            double entrada;            
            int pessoas = 10;
            int count = 0;

            for (int i = 0; i < pessoas; i++)
            {
                Console.Write("\aHora que a pessoa entrou: ");
                entrada = double.Parse(Console.ReadLine());
                if (entrada > 9 && entrada <= 16)
                {
                    count++;
                }
            }
            Console.WriteLine("\a");
            Console.WriteLine("\a\tDas {0} pessoas que entraram, {1} entraram durante o horário de expediente.",pessoas,count);
            Console.ReadKey();
        }
    }
}
