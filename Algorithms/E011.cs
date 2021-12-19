using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Algorithms
{
    class E011
    {
        // Apple and Orange
        // https://www.hackerrank.com/challenges/apple-and-orange/problem

        // INPUT
        // The first line contains two space-separated integers denoting the respective values of s and t.
        // The second line contains two space-separated integers denoting the respective values of a and b.
        // The third line contains two space-separated integers denoting the respective values of m and n.
        // The fourth line contains m space-separated integers denoting the respective distances that each apple falls from point a.
        // The fifth line contains n space-separated integers denoting the respective distances that each orange falls from point b.

        // CONSTRAINTS
        // 1 =< s,t,a,b,m,n <= 10^5
        // -10^5 =< d <= 10^5
        // a < s < t < b
        // a apple tree, s-t house, b orange tree
        // d distance between the fallen fruit from its tree

        // OUTPUT
        // Print two integers on two different lines:
        // The first integer: the number of apples that fall on Sam's house.
        // The second integer: the number of oranges that fall on Sam's house.


        public static void Input()
        {
            Random rand = new Random();
            
            int a_appleTreePosition = rand.Next(1, ((int)Math.Pow(10, 5)));
            int s_startHousePosition = a_appleTreePosition + rand.Next(1, ((int)Math.Pow(10, 5)));
            int t_endHousePosition = s_startHousePosition + rand.Next(1, ((int)Math.Pow(10, 5)));
            int b_orangeTreePosition = t_endHousePosition + rand.Next(1, ((int)Math.Pow(10, 5)));
            int numApples = rand.Next(1, ((int)Math.Pow(10, 5)));
            int numOranges = rand.Next(1, ((int)Math.Pow(10, 5)));

            List<int> fallenApplesDistance = new(numApples);
            for (int i = 0; i < numApples; i++)
            {
                int item = rand.Next(-((int)Math.Pow(10, 5)), ((int)Math.Pow(10, 5)));
                fallenApplesDistance.Add(item);
            }
            
            List<int> fallenOrangesDistance = new(numOranges);
            for (int i = 0; i < numOranges; i++)
            {
                int item = rand.Next(-((int)Math.Pow(10, 5)), ((int)Math.Pow(10, 5)));
                fallenOrangesDistance.Add(item);
            }

            //Console.WriteLine("fallenApplesDistance: " + string.Join(",", fallenApplesDistance));
            //Console.WriteLine("fallenOrangesDistance: " + string.Join(",", fallenOrangesDistance));

            CountApplesAndOranges(s_startHousePosition,t_endHousePosition, a_appleTreePosition, b_orangeTreePosition, fallenApplesDistance, fallenOrangesDistance);
        }

        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int s_startHousePosition = s;
            int t_endHousePosition = t;
            int a_appleTreePosition = a;
            int b_orangeTreePosition = b;

            for (int i = 0; i < apples.Count; i++)
            {
                apples[i] = apples[i] + a_appleTreePosition;
            }

            for (int i = 0; i < oranges.Count; i++)
            {
                oranges[i] = oranges[i] + b_orangeTreePosition;
            }

            int countApples = 0;
            foreach(int item in apples)
            {
                if(item >= s_startHousePosition && item <= t_endHousePosition)
                {
                    countApples++;
                }
            }

            int countOranges = 0;
            foreach (int item in oranges)
            {
                if (item >= s_startHousePosition && item <= t_endHousePosition)
                {
                    countOranges++;
                }
            }

            Console.WriteLine($"\na_appleTreePosition {a}");
            Console.WriteLine("s_startHousePosition: " + string.Join(",", s_startHousePosition));
            Console.WriteLine("t_endHousePosition: " + string.Join(",", t_endHousePosition));
            Console.WriteLine($"b_orangeTreePosition {b}");
            //Console.WriteLine("\napples: " + string.Join(",", apples));
            //Console.WriteLine("oranges: " + string.Join(",", oranges));

            Console.WriteLine($"{countApples}");
            Console.WriteLine($"{countOranges}");

        }
    }
}
