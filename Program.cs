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
        static List<int> GetInput(string inputPath)
        {
            return File.ReadAllLines(inputPath).Select(int.Parse).ToList();
        }

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            List<int> testFreq = GetInput(@"./Data/DayONE_input.txt");
            
            int output1 = DayOne.CalibratedFrequency(testFreq);
            int output2 = DayOne.FirstRepeatFrequency(testFreq);
            
            Console.WriteLine($"part one : {output1}\npart two : {output2}");
            
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine($"RunTime > {ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds / 10}");
        }
    }
}
