using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Linq;


namespace AdventOfCode
{
    class Program
    {
        static List<int> GetIntListInput(string inputPath)
        {
            return File.ReadAllLines(inputPath).Select(int.Parse).ToList();
        }

        static List<string> GetStrListInput(string inputPath)
        {
            return File.ReadAllLines(inputPath).ToList();
        }

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //List<int> testFreq = GetIntListInput(@"./Data/DayONE_input.txt");
            // int output1 = DayOne.CalibratedFrequency(testFreq);
            // int output2 = DayOne.FirstRepeatFrequency(testFreq);

            List<string> inputData = GetStrListInput(@"./Data/DayTWO_input.txt");
            var output1 = DayTwo.checksum(inputData);
            //int output2 = DayTwo.parttwo(testFreq);
            
            //string output1 = "nope";
            string output2 = "also nope";

            Console.WriteLine($"part one : {output1}\npart two : {output2}");
            
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine($"RunTime > {ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds / 10:00}");
        }
    }
}
