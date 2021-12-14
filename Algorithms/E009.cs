using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class E009
    {
        // Time Conversion
        // https://www.hackerrank.com/challenges/time-conversion/problem

        // INPUT
        // A single string s that represents a time in 12-hour clock format (i.e.: hh:mm:ssAM  or hh:mm:ssPM).

        // CONSTRAINTS
        // 

        // OUTPUT
        // string: the time in  24-hour format


        public static void Input()
        {
            string time = "12:53:34AM";

            TimeConversion(time);
        }

        public static string TimeConversion(string time)
        {
            // remove = delete the string from index X (starts at 0) to length Y
            var editedTime = time.Remove(8, 2);
            var midday = time.Remove(0, 8);
            char delimiterChar = ':';

            string[] tens = editedTime.Split(delimiterChar);
            //System.Console.WriteLine($"{tens.Length} words in text:");
            if(tens[0]=="12"){
                tens[0] = "00";
            }
            
            int firstTen = Int32.Parse(tens[0]);

            if (midday == "PM")
            {
                firstTen += 12;
                tens[0] = firstTen.ToString();
            }

            foreach (var ten in tens)
            {
                System.Console.WriteLine($"<{ten}>");
            }
            //System.Console.WriteLine($"<{midday}>");

            string time24h = ($"{tens[0]}:{tens[1]}:{tens[2]}");
            //System.Console.WriteLine(time24h);

            return time24h;
        }






}
}
