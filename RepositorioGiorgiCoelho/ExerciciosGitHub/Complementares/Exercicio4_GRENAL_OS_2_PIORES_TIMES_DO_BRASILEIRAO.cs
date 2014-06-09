using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Complementares_GitHub_UNIDADE_VI
{
    class Exercicio4_GRENAL_OS_2_PIORES_TIMES_DO_BRASILEIRAO
    {
        public static void Maini(String[] args)
        {
            /*
            4) Escreva um programa para receber números aleatórios de gols marcados pelo Grêmio 
            e o número de gols marcados pelo Inter em um GRENAL. Escrever o nome do vencedor. 
            Mostre no final o vencedor e quando foi a partida. Caso não haja vencedor deverá
            ser impressa a palavra EMPATE. 
             */                     

            Random gerador = new Random();
            int gol_inter = gerador.Next(0,6); // que mentira, daria 0 à 0 de tão ruins os times =/
            int gol_gremio = gerador.Next(0,6);
            
            if(gol_inter > gol_gremio)
            {
                Console.WriteLine("Internacional: {0} | Grêmio: {1}",gol_inter,gol_gremio);
                Console.WriteLine("\n\tInternacional ganhou!");
            }
            else if (gol_gremio > gol_inter)
            {
                Console.WriteLine("Internacional: {0} | Grêmio: {1}", gol_inter, gol_gremio);
                Console.WriteLine("\n\tGrêmio ganhou!");
            }
            else
            {
                Console.WriteLine("Internacional: {0} | Grêmio: {1}", gol_inter, gol_gremio);
                Console.WriteLine("\n\tDeu empate!");
            }

            Console.ReadKey();
        }
    }
}
