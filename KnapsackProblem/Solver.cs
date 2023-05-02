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

            var maxWeight = weights[0];
            var maxValue = values[0];

            var bestValue = 0.0;
            var tempValue = 0.0;


            for (int i = 1; i < weights.Count; i++)
            {
                var totalValue = 0.0;
                var counter = 0.0;
                List<UInt32> resultValues = new List<UInt32>();
                List<UInt32> resultWeights = new List<UInt32>();

                Console.WriteLine(values[i] + " " + weights[i]);
                resultValues.Add(values[i]);
                resultWeights.Add(weights[i]);
                counter += weights[i];
                totalValue += (values[i]);


                if (tempValue > bestValue)
                {
                    bestValue = tempValue;
                    Console.WriteLine("Best:" + bestValue);
                }
                else
                {
                    bestValue = tempValue;
                }
                for (int j = i + 1; j < weights.Count; j++)
                {

                    if (counter <= maxWeight)
                    {
                        counter += weights[j];
                        if (counter > maxWeight)
                        {
                            Console.WriteLine("Limit Exceeded!!!!!!!!!!!!!!!!!");
                            counter -= weights[j];
                        }
                        else
                        {
                            Console.WriteLine(values[j] + " " + weights[j]);
                            resultValues.Add(values[j]);
                            resultWeights.Add(weights[j]);
                            totalValue += (values[j]);
                            tempValue = totalValue;
                        }
                    }
                    Console.WriteLine("Total Value:" + totalValue + "    " + "Total Weight:" + counter);
                }

                Console.WriteLine("---------------------------");

            }



        }
    }
}
