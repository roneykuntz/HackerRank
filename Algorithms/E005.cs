using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class E005
    {
        //Plus Minus
        //https://www.hackerrank.com/challenges/plus-minus/problem

        // INPUT
        // The first line contains an integer n, the size of the array.
        // The second line contains n space-separated integers that describe arr[n].

        // CONSTRAINTS
        // 0 < n <= 100
        // -100 =< arr[i] <= +100

        // OUTPUT
        // Print the following 3 lines, each to 6 decimals:
        // proportion of positive values
        // proportion of negative values
        // proportion of zeros

        public static void Input()
        {
            Random rand = new Random();
            int sizeOfCollection = rand.Next(3, 21);
            Console.WriteLine("Size of the collection: " + sizeOfCollection);

            List<int> numbersList = new(sizeOfCollection);
            for(int i=0; i<sizeOfCollection; i++)
            {
                numbersList.Add(rand.Next(-100, 100));
            }

            Console.WriteLine("Numbers list: " + string.Join(",",numbersList));

            PlusMinus(numbersList);
        }

        public static void PlusMinus(List<int> numbersList)
        {
            int positiveValues = 0;
            int negativeValues = 0;
            int zeros = 0;

            foreach(int item in numbersList)
            {
                if (item > 0)
                {
                    positiveValues++;
                }
                else if (item < 0)
                {
                    negativeValues++;
                }
                else
                {
                    zeros++;
                }
            }

            Console.WriteLine("Positives proportion: {0:0.000000}", ((double)positiveValues / (double)numbersList.Count));
            Console.WriteLine("Negatives proportion: {0:0.000000}", ((double)negativeValues / (double)numbersList.Count));
            Console.WriteLine("Zeros proportion: {0:0.000000}", ((double)zeros / (double)numbersList.Count));

        }
    }
}
