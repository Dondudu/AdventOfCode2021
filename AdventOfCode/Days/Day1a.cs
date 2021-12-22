using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    class Day1a : AbstractDay
    {
        public Day1a() : base("Day1a")
        {
        }

        public override string Solve(List<string> input)
        {
            int largerCount = 0;
            int? previous = null;

            foreach(string i in input)
            {
                int current = int.Parse(i);

                if(previous != null)
                {
                    if (current > previous.Value)
                    {
                        largerCount++;
                    }
                }

                previous = current;
            }
            return largerCount.ToString();
        }
    }
}
