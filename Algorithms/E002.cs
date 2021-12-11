using System;
using System.Collections.Generic;

namespace Algorithms
{
    class E002
    {
        //CompareTheTriplets
        //https://www.hackerrank.com/challenges/compare-the-triplets/problem

        public static void Entrada()
        {
            Random rand = new Random();

            List<int> alice = new List<int>();

            int aliceClarity = rand.Next(1, 100);
            int aliceOriginality = rand.Next(1, 100);
            int aliceDifficulty = rand.Next(1, 100);

            alice.Add(aliceClarity);
            alice.Add(aliceOriginality);
            alice.Add(aliceDifficulty);

            Console.WriteLine("Notas Alice: " + string.Join(",", alice));

            List<int> bob = new List<int>();

            int bobClarity = rand.Next(1, 100);
            int bobOriginality = rand.Next(1, 100);
            int bobDifficulty = rand.Next(1, 100);

            bob.Add(bobClarity);
            bob.Add(bobOriginality);
            bob.Add(bobDifficulty);

            Console.WriteLine("Notas Bob: " + string.Join(",", bob));

            var resposta = CompareTriplets(alice, bob);

            Console.WriteLine(string.Join(",", resposta));

        }

        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int notaAlice = 0;
            int notaBob = 0;

            int cont = 0;
            while (cont < 3)
            {
                if (a[cont] > b[cont])
                {
                    notaAlice++;
                }
                if (a[cont] < b[cont])
                {
                    notaBob++;
                }
                cont++;
            }

            List<int> score = new List<int>();
            score.Add(notaAlice);
            score.Add(notaBob);

            return score;
        }

    }
}
