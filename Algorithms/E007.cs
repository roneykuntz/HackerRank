using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class E007
    {
        // Mini-Max Sum
        // https://www.hackerrank.com/challenges/mini-max-sum/problem

        // INPUT
        // A single line of five space-separated integers.

        // CONSTRAINTS
        // 1 < arr[i] <= 10^9

        // OUTPUT
        // Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers.
        // (The output can be greater than a 32 bit integer.)


        public static void Input()
        {
            Random rand = new Random();
            List<int> itensList = new();
            
            for(int i = 0; i < 5; i++)
            {
                int item = rand.Next(1, 1000000000);
                itensList.Add(item);
            }
            Console.WriteLine("List: " + string.Join(",", itensList));

            MiniMaxSum(itensList);
        }

        public static void MiniMaxSum(List<int> itensList)
        {
            long min = itensList.Min();
            long max = itensList.Max();

            //Console.WriteLine("Min/max: "+min.ToString() + " " + max.ToString());


            long maxSum = 0;
            long minSum = 0;
            long equalSum = 0;

            if (min != max)
            {
                for (int i = 0; i < itensList.Count; i++)
                {
               
                    if (itensList[i] != min)
                        maxSum += itensList[i];
                    if (itensList[i] != max)
                        minSum += itensList[i];
                }
            }
            else
            {
                // in cases where the array has totally equal items, like [5,5,5,5,5]

                for (int i = 0; i < itensList.Count; i++)
                {
                    equalSum += itensList[i];
                }

                maxSum = equalSum - min;
                minSum = equalSum - max;

            }
            

            Console.WriteLine(minSum.ToString()+" "+maxSum.ToString());

        }

    }
}
