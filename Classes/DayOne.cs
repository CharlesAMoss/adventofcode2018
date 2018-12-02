using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class DayOne
    {
        // https://adventofcode.com/2018/day/1
        // Part One
        public static int CalibratedFrequency(List<int> input)
        {
            return input.Sum();
        }

        // Part Two
        public static int FirstRepeatFrequency(List<int> input, int start, List<int> log)
        {
            int freq = start;
            List<int> freqLog = log;
            
            foreach (var i in input)
            {
                freq += i;
                freqLog.Add(freq);
            }
            
            var output = freqLog.GroupBy(x => x)
                        .Where(g => g.Count() > 1)
                        .Select(g => g.Key)
                        .ToList();
            
            if (output.Count() == 0) {
                return FirstRepeatFrequency(input, freq, freqLog);
            } else {    
                return output[0];
            }
        }
    } 
}