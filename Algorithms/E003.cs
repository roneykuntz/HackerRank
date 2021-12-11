using System;
using System.Collections.Generic;

namespace Algorithms
{
    class E003
    {
        //A Very Big Sum
        //https://www.hackerrank.com/challenges/a-very-big-sum/problem

        public static void Entrada()
        {
            Random rand = new Random();

            var tamanho = rand.Next(1, 10);
            List<long> valores = new List<long>(tamanho);

            int cont = 0;

            Random rand2 = new Random();

            while (cont < tamanho)
            {
                valores.Add(rand2.Next(0, 1000000000));
                cont++;
            }

            var resposta = AVeryBigSum(valores);

            Console.WriteLine("Tamanho: " + tamanho);
            Console.WriteLine("Valores: " + string.Join(", ", valores));
            Console.WriteLine("Soma: " + string.Join(",", resposta));
        }

        public static long AVeryBigSum(List<long> collection)
        {
            long soma = 0;

            foreach (long item in collection)
            {
                soma += item;
            }

            return soma;
        }
    }
}
