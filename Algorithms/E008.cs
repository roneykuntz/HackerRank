using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class E008
    {
        // Birthday Cake Candles
        // https://www.hackerrank.com/challenges/birthday-cake-candles/problem

        // INPUT
        // The first line contains a single integer, n, the size of candles[].
        // The second line contains n space-separated integers, where each integer i describes the height of candles[i].

        // CONSTRAINTS
        // 1 =< n <= 10^5
        // 1 =< arr[i] <= 10^7

        // OUTPUT
        // int: the number of candles that are tallest


        public static void Input()
        {
            Random rand = new Random();
            int candlesNumber = new();
            candlesNumber = rand.Next(1, ((int)Math.Pow(10,5)));

            List<int> candlesHeights = new();

            for (int i = 0; i < candlesNumber; i++)
            {
                int item = rand.Next(1, ((int)Math.Pow(10, 7)));
                candlesHeights.Add(item);
            }
            Console.WriteLine("List: " + string.Join(",", candlesHeights));

            BirthdayCakeCandles(candlesHeights);
        }

        public static int BirthdayCakeCandles(List<int> candlesHeights)
        {
            int maxHeight = candlesHeights.Max();
            int tallestCandles = 0;

            for(int i = 0; i < candlesHeights.Count; i++)
            {
                if (candlesHeights[i] == maxHeight)
                    tallestCandles++;
            }

            Console.WriteLine(tallestCandles);

            return tallestCandles;

        }

    }
}
