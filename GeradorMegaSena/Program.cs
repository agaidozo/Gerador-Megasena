using System;
using System.Collections.Generic;
using System.Linq;

namespace GeradorMegaSena
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string numerosString = "Numeros: ";
            List<int> n = GerarNumeros();

            foreach (int item in n)
            {
                numerosString += item + ", ";
            }

            numerosString = numerosString.Substring(0, numerosString.Length - 2);

            Console.Write(numerosString);
            Console.ReadLine();
        }

        private static List<int> GerarNumeros()
        {
            Random random = new Random();
            List<int> numeros = new List<int>{
                7, 40, 44, 50, 52, 57,
                19, 20, 26, 51, 52, 57,
                19, 21, 26, 31, 42, 49,
                8, 14, 27, 34, 52, 54,
                9, 23, 28, 40, 48, 59,
                7, 16, 21, 33, 55, 60
            };

            List<int> nRetorno = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                nRetorno.Add(numeros[random.Next(0, numeros.Count)]);
            }

            List<int> retorno = nRetorno.Distinct().OrderBy(x => x).ToList();

            while (retorno.Count != 6)
            {
                for (int i = retorno.Count; i < 6; i++)
                {
                    retorno.Add(numeros[random.Next(0, numeros.Count)]);
                }

                retorno = retorno.Distinct().OrderBy(x => x).ToList();
            }

            return retorno;
        }
    }
}
