using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    // https://adventofcode.com/2018/day/1
    public class DayTwo 
    {
        //Part One
        public static int checksum(List<string> inputs)
        {
            
            int twos =   inputs.Count(c => c.GroupBy(g => g).Any(a => a.Count() == 2));
            int threes = inputs.Count(c => c.GroupBy(g => g).Any(a => a.Count() == 3));

            return twos * threes;;
        }

        
    }
}