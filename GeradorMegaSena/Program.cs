using System;
using System.Collections.Generic;
using System.Linq;

namespace GeradorMegaSena
{
    internal class Program
    {
        private static List<int> GerarNumeros()
        {
            Random random = new Random();
            List<int> numeros = new List<int>{
                07, 40, 44, 50, 52, 57,
                19, 20, 26, 51, 52, 57,
                19, 21, 26, 31, 42, 49,
                08, 14, 27, 34, 52, 54,
                09, 23, 28, 40, 48, 59,
                07, 16, 21, 33, 55, 60,
                10, 05, 53, 04, 23, 54,
                26, 29, 36, 49, 50, 59,
                31, 33, 34, 35, 39, 48,
                14, 26, 35, 38, 45, 53,
                16, 18, 31, 39, 42, 44,
                08, 09, 10, 24, 42, 44,
                03, 19, 34, 44, 56, 58,
                01, 08, 19, 33, 36, 48,
                04, 11, 16, 22, 29, 33,
                07, 16, 37, 53, 57, 59
            };

            List<int> nRetorno = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                nRetorno.Add(numeros[random.Next(numeros.Count)]);
            }

            List<int> retorno = nRetorno.Distinct().OrderBy(x => x).ToList();

            while (retorno.Count != 6)
            {
                for (int i = retorno.Count; i < 6; i++)
                {
                    retorno.Add(numeros[random.Next(numeros.Count)]);
                }

                retorno = retorno.Distinct().OrderBy(x => x).ToList();
            }

            return retorno;
        }

        private static void Main(string[] args)
        {
            Random random = new Random();
            List<int> dias = new List<int> { 25, 19, 16, 35, 12, 31, 34, 48, 16 };
            string numerosString = "Dia de apostar do mês: ";
            numerosString += dias[random.Next(dias.Count)] + "\n";
            numerosString += "Numeros: ";
            List<int> n = GerarNumeros();

            foreach (int item in n)
            {
                numerosString += item + ", ";
            }

            numerosString = numerosString.Substring(0, numerosString.Length - 2);

            Console.Write(numerosString);
            Console.ReadLine();
        }
    }
}