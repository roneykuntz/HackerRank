using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class E010
    {
        // Grading Students
        // https://www.hackerrank.com/challenges/grading/problem

        // INPUT
        // The first line contains a single integer, n, the number of students.
        // Each line i of the n subsequent lines contains a single integer, grades[i].

        // CONSTRAINTS
        // 1 =< n <= 60
        // 0 =< grades[i] <= 100

        // OUTPUT
        // int[n]: the grades after rounding as appropriate


        public static void Input()
        {
            Random rand = new Random();
            int studentsNumber = new();
            studentsNumber = rand.Next(1, 60);

            List<int> grades = new();

            for (int i = 0; i < studentsNumber; i++)
            {
                int item = rand.Next(0, 100);
                grades.Add(item);
            }
            Console.WriteLine("Grades list________: " + string.Join(",", grades));

            GradingStudents(grades);
        }

        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> roundedGrades = new List<int>(grades.Count);

            for(int i=0;i<grades.Count;i++)
            {
                if (grades[i] < 38)
                {
                    roundedGrades.Add(grades[i]);

                }else if(grades[i] >= 38 ){

                    int roundItem = grades[i];
                    int countIncrement = 0;

                    while(roundItem % 5 != 0)
                    {
                        roundItem += 1;
                        countIncrement++;
                    }
                    if (countIncrement < 3)
                    {
                        roundedGrades.Add((int)(Math.Round(grades[i] / 5.0)*5));
                    }
                    else
                    {
                        roundedGrades.Add(grades[i]);
                    }
                }
            }

            Console.WriteLine("Rounded grades list: " + string.Join(",", roundedGrades));
            return roundedGrades;
        }


    }
}
