using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class E006
    {
        // Staircase
        // https://www.hackerrank.com/challenges/staircase/problem

        // INPUT
        // A single integer n denoting the size of the staircase.

        // CONSTRAINTS
        // 0 < n <= 100

        // OUTPUT
        // Print a staircase of size n using # symbols and spaces.
        // Note: The last line must have 0 spaces in it.


        public static void Input()
        {
            Random rand = new Random();
            int sizeOfStaircase = rand.Next(3, 20);
            Console.WriteLine("Size of the staircase: " + sizeOfStaircase);
            Staircase(sizeOfStaircase);
        }

        public static void Staircase(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                string hashtag = "#";
                string space = " ";
                string line = "";
                // spaces
                for(int j = n-i; j > 0; j--)
                {
                    line += space;
                }
                // hashtags
                for(int k = i; k > 0; k--)
                {
                    line += hashtag;
                }

                Console.WriteLine(line);
            }
        }
    }
}
