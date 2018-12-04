using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    // https://adventofcode.com/2018/day/3
    public class DayThree 
    {
        //Part One
        public static int FabricClaims(List<string> inputs)
        {

            Dictionary<int, int> log = new Dictionary<int, int>();

            List<FabricClaim> Claims = new List<FabricClaim>();
            foreach (var i in inputs)
            {
               var spl = i.Split(' ');
               var idIndex = Convert.ToInt32(spl[0].TrimStart('#'));
               var pos = spl[2].TrimEnd(':').Split(',');
               var piece = spl[3].Split('x');
               Claims.Add(new FabricClaim(idIndex, Convert.ToInt32(pos[0]),Convert.ToInt32(pos[1]),Convert.ToInt32(piece[0]),Convert.ToInt32(piece[1])));
            }
            
            foreach (var claim in Claims)
            {
                for (var i = claim.FromLeft; i < claim.FromLeft + claim.Width; i++)
                {
                    for (var j = claim.FromTop; j < claim.FromTop + claim.Height; j++)
                    {
                        int key = j * 10000 + i;
                        if (!log.ContainsKey(key))
                        {
                            log.Add(key, 0);
                        }
                        log[key]++;
                    }
                }
            }

            return log.Count(p => p.Value >= 2);
        }

        public static void partTwo(List<string> inputs)
        {    
   

        }   
    }

    public class FabricClaim
    {
        public int Id {get; set;}
        public int FromLeft {get; set;}
        public int FromTop {get; set;}
        public int Width {get; set;}
        public int Height {get; set;}

        public FabricClaim(int id, int fromLeft, int fromTop, int width, int height)
        {
            this.Id = id;
            this.FromLeft = fromLeft;
            this.FromTop = fromTop;
            this.Width = width;
            this.Height = height;
        }
    }
}