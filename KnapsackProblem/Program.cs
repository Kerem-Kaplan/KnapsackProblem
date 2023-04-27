using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReadInput readInput = new();
            Solver solver = new();

            //Console.WriteLine("----------------------------");

            //List<UInt32> calculateValues = solver.CalculateValues();

            //for (int i = 0; i < calculateValues.Count; i++)
            //{
            //    Console.WriteLine(calculateValues[i]);
            //}

            solver.SolvingResult();

        }
    }
}
