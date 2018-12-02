using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    // https://adventofcode.com/2018/day/2
    public class DayTwo 
    {
        //Part One
        public static int Checksum(List<string> inputs)
        {
            
            int twos =   inputs.Count(c => c.GroupBy(g => g).Any(a => a.Count() == 2));
            int threes = inputs.Count(c => c.GroupBy(g => g).Any(a => a.Count() == 3));

            return twos * threes;;
        }

        //Part Two
        public static string ScanIds(List<string> inputs)
        {    
            int i = 0;
            foreach (var input in inputs)
            {
                var found = inputs.Select(s => s.Remove(i, 1)).GroupBy(g => g).FirstOrDefault(f => f.Count() > 1);
                if (found != null)
                {
                    return found.First();
                } 
                i++; 
            } 
            return "none";  
        }   
    }
}