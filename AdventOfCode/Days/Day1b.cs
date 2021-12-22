using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    class Day1b : AbstractDay
    {
        public Day1b() : base("Day1b")
        {
        }

        public override string Solve(List<string> input)
        {
            int largerCount = 0;
            List<int> window = new List<int>();

            for(int i = 3; i< input.Count; i++)
            {
                int previousWindow = GetWindowSum(input, i - 1);
                int currentWindow = GetWindowSum(input, i);
                if (currentWindow > previousWindow)
                    largerCount++;
            }

            return largerCount.ToString();
        }

        private int GetWindowSum(List<string> input, int index)
        {
            int first = Convert.ToInt32(input[index]);
            int second = Convert.ToInt32(input[index-1]);
            int third = Convert.ToInt32(input[index-2]);

            return first + second + third;
        }
    }
}
