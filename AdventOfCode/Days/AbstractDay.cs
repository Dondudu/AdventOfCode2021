using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    public abstract class AbstractDay
    {
        string day = "";
        protected AbstractDay(string day)
        {
            this.day = day;
        }

        public void Run()
        {
            //string outputFile = $"C:/Temp/Outputs/{day}.txt";
            List<string> input = File.ReadAllText($"Inputs/{day}.txt", Encoding.UTF8).Split("\r\n").ToList();
            string output = Solve(input);
            Console.WriteLine(output);
            //File.WriteAllText(outputFile, output);
        }

        public abstract string Solve(List<string> input);
    }
}
