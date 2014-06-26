using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Unidades.Collections
{
    internal class ExercicioFixaacao
    {
        public static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            Exercicio5();
        }

        private static void Exercicio1()
        {
            List<int> numeros = new List<int>();
            Random gerador = new Random();

            for (int i = 0; i < 100; i++)
            {
                numeros.Add(gerador.Next(0, 1000));
            }
            Console.WriteLine("===============================");

            //Ordenando os números.
            OrdenaNumeros(numeros);
            Console.WriteLine("===============================");

            //Invertendo os números.
            InvertendoValor(numeros);
            Console.ReadKey();
        }

        //Métodos do Exercício 1
        #region
        private static void InvertendoValor(List<int> numeros)
        {
            numeros.Reverse();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            //OU//
            /*foreach (var i in numeros )
            {
              Console.WriteLine(i); 
            }*/
        }

        private static void OrdenaNumeros(List<int> numeros)
        {
            numeros.Sort();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            //OU//
            /*foreach (var i in numeros )
            {
              Console.WriteLine(i); 
            }*/
        }
        #endregion

        private static void Exercicio2()
        {
            List<double> numeros = new List<double>();
            Random gerador = new Random();

            for (int i = 0; i < 100; i++)
            {
                numeros.Add(gerador.NextDouble());
                numeros[i] = numeros[i] * 100;
                Console.WriteLine(numeros[i].ToString("##.##"));
            }
            Console.WriteLine("==============================");

            Console.WriteLine("Maior Valor: " + numeros.Max().ToString("##.##"));
            Console.WriteLine("Menor Valor: " + numeros.Min().ToString("##.##"));
            Console.WriteLine("Média dos Valores: " + numeros.Average().ToString("##.##"));
            Console.WriteLine("Soma dos Valores: " + numeros.Sum().ToString("##.##"));

            Console.WriteLine("==============================");
            Console.ReadKey();
        }

        private static void Exercicio3()
        {
            List<string> nomes = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nome: ");
                nomes.Add(Console.ReadLine());
            }

            /*IEnumerable<string> ColocaEmOrdemAString= from i in nomes orderby i ascending select i;
            foreach (var item in ColocaEmOrdemAString)
            {
                Console.WriteLine(item);
            }

            ============ OU ===============
            */
            nomes.Sort();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.ReadKey();
        }

        private static void Exercicio4()
        {
            List<int> numeros = new List<int>();
            IList<int> numeros2 = new List<int>();
            ArrayList nomes = new ArrayList();
            Dictionary<int, char> alfabeto = new Dictionary<int, char>();
            char letra;

            Random gerador = new Random();
            for (int i = 0; i < 10; i++)
            {
                numeros.Add(gerador.Next(0, 11));
                numeros2.Add(gerador.Next(0, 11));
                Console.Write("Nome: ");
                nomes.Add(Console.ReadLine());
                Console.Write("Letra: ");
                letra = char.Parse(Console.ReadLine());
                alfabeto.Add(i, letra);
            }
            Console.WriteLine("Numeros: ");
            numeros.Sort();
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========");
            
            Console.WriteLine("Numeros 2: ");
            foreach (var item in numeros2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========");
            nomes.Sort();

            Console.WriteLine("Nomes: ");
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========");

            Console.WriteLine("Alfabeto: ");
            foreach (var item in alfabeto)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static void Exercicio5()
        {
            int recebeGerador;
            List<string> times = new List<string>();
            Random geraGrupos = new Random();
            ArrayList grupos = new ArrayList();

            TimesCopa2014(times);
            GruposCopa(grupos);

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("====================");
                Console.WriteLine("Grupo " + grupos[i] + ":");
                for (int z = 0; z < 4; z++)
                {
                volta:
                    recebeGerador = geraGrupos.Next(0, 32);
                    if (times[recebeGerador] != null)
                    {
                        Console.WriteLine("");
                        Console.Write(times[recebeGerador]);
                        times[recebeGerador] = null;
                    }
                    else
                    {
                        goto volta;
                    }
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }

        //Métodos do Exercício 5
        #region
        private static void GruposCopa(ArrayList grupos)
        {
            grupos.Add("A");
            grupos.Add("B");
            grupos.Add("C");
            grupos.Add("D");
            grupos.Add("E");
            grupos.Add("F");
            grupos.Add("G");
            grupos.Add("H");
        }

        private static void TimesCopa2014(List<string> times)
        {
            times.Add("Brasil");
            times.Add("Japão");
            times.Add("Austrália");
            times.Add("Irã");
            times.Add("Coreia Do Sul");
            times.Add("Holanda");
            times.Add("Itália");
            times.Add("Argentina");
            times.Add("EUA");
            times.Add("Costa Rica");
            times.Add("Alemanha");
            times.Add("Bélgica");
            times.Add("Suiça");
            times.Add("Colômbia");
            times.Add("Espanha");
            times.Add("Bósnia");
            times.Add("Rússia");
            times.Add("Inglaterra");
            times.Add("Chile");
            times.Add("Equador");
            times.Add("Honduras");
            times.Add("Nigéria");
            times.Add("Camarões");
            times.Add("Costa do Marfim");
            times.Add("Portugal");
            times.Add("França");
            times.Add("Grécia");
            times.Add("Croácia");
            times.Add("Argélia");
            times.Add("Gana");
            times.Add("México");
            times.Add("Uruguai");
        }
        #endregion
    }
}