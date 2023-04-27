using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    public class Solver
    {

        public List<UInt32> CalculateValues()
        {
            ReadInput readInput = new();

            List<UInt32> values = readInput.GetValue();
            List<UInt32> weights = readInput.GetWeight();

            List<UInt32> calculateValues = new();

            for (int i = 0; i < weights.Count; i++)
            {
                var totalValue = values[i] * weights[i];
                calculateValues.Add(totalValue);
                //Console.WriteLine(totalValue);
            }

            return calculateValues;
        }

        public void SolvingResult()
        {
            ReadInput readInput = new();

            List<UInt32> values = readInput.GetValue();
            List<UInt32> weights = readInput.GetWeight();

            var totalWeight = weights[0];
            var totalValue = values[0];



            for (int i = 1; i < weights.Count; i++)
            {
                Console.WriteLine(values[i] + " " + weights[i]);
            }



        }
    }
}
