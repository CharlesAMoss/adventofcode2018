using System;
using System.IO;
using System.Collections.Generic;


namespace AdventOfCode
{
    class Program
    {
        static IEnumerable<string> GetInput(string inputPath)
        {
            return File.ReadLines(inputPath.ToString());
        }

        static void Main(string[] args)
        {
            string dataPath = @"./Data/DayONE_input.txt";
            var linesRead = File.ReadLines(dataPath);
          
            var testFreq = new List<int>();
            foreach (var l in linesRead)
            {
                testFreq.Add(Int32.Parse(l));
            }

            // var testFreq = new List<int> (new int[] { +1, +1, +1 });
            int output = DayOne.CalibratedFrequency(testFreq);
            Console.WriteLine(output);
        }
    }
}
