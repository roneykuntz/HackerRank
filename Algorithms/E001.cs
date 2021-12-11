using System;
using System.Collections.Generic;

namespace Algorithms
{
    class E001
    {
        //SolveMeFirst
        //https://www.hackerrank.com/challenges/solve-me-first/problem

        public static void Input()
        {
            Random rand = new Random();

           
            int a = rand.Next(1, 100);
            int b = rand.Next(1, 100);

            Console.WriteLine("Entrada: " + a.ToString() + "," + b.ToString());

            var resposta = SolveMeFirst(a,b);

            Console.WriteLine("Resposta: "+ string.Join(",", resposta));

        }

        static int SolveMeFirst(int a, int b)
        {
            // Hint: Type return a+b; below  
            int calculo = a + b;
            return calculo;
        }

    }
}
