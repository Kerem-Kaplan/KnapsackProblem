using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            ReadInput readInput = new();
            Solver solver = new();

            //Console.WriteLine("----------------------------");

            //List<UInt32> calculateValues = solver.CalculateValues();

            //for (int i = 0; i < calculateValues.Count; i++)
            //{
            //    Console.WriteLine(calculateValues[i]);
            //}

            solver.SolvingResult();
            stopwatch.Stop();
            Console.WriteLine("\n\nİşlem süresi: {0}", stopwatch.Elapsed.Milliseconds + " milisaniye");

        }
    }
}
