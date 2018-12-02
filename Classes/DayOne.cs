using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    public class DayOne
    {

        // Part One
        public static int CalibratedFrequency(List<int> input)
        {
            int freq = 0;
            foreach (var i in input)
            {
                freq += i;
            }
            return freq;
        }


    } 
}