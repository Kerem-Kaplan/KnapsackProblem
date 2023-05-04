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
            ReadInput readInput = new();//sınıfın türetilmesi

            List<UInt32> values = readInput.GetValue(); //value değeri alınıyor
            List<UInt32> weights = readInput.GetWeight(); //weight değeri alınıyor

            var maxWeight = weights[0];     //maksimum weight değeri ataması
            var maxValue = values[0];       //maksimum valuet değeri ataması

            var bestValue = 0.0;            //en iyi sonuç için oluşturulan değişken
            var tempValue = 0.0;            //en iyi sonuca göre karşılaştırması yapılacak olan
                                            //geçisi değişken

            int[] status = new int[values.Count];   //itemlerin çantaya eklenme durumu 0-1

            for (int n = 1; n < values.Count; n++)  //başlangıçta çantanın boş tanımlanması
            {
                status[n] = 0;
            }

            for (int i = 1; i < weights.Count; i++)
            {
                var totalValue = 0.0;
                var counter = 0.0;
                List<UInt32> resultValues = new();
                List<UInt32> resultWeights = new();



                //Console.WriteLine("Value: " + values[i] + "\t " + "Weight: " + weights[i]);
                if (weights[i] <= maxWeight)
                {
                    resultValues.Add(values[i]);    //ilk value eklenmesi
                    resultWeights.Add(weights[i]);  //ilk weight eklenmesi
                    counter += weights[i];
                    totalValue += (values[i]);

                    status[i] = 1;
                }


                // Console.WriteLine("\nValue: " + values[i] + "\t " + "Weight: " + weights[i]);

                for (int j = i + 1; j < weights.Count; j++)
                {
                    if (counter <= maxWeight)
                    {
                        counter += weights[j];
                        if (counter > maxWeight)
                        {
                            status[j] = 0;
                            //Console.WriteLine("\nLimit Exceeded!!!!!!!!!!!!!!!!!");
                            counter -= weights[j];
                        }
                        else
                        {
                            //Console.WriteLine("Value: " + values[j] + "\t " + "Weight: " + weights[j]);
                            resultValues.Add(values[j]);
                            resultWeights.Add(weights[j]);
                            totalValue += (values[j]);
                            status[j] = 1;
                            tempValue = totalValue;
                        }
                    }

                }


                if (tempValue > bestValue)
                {
                    bestValue = tempValue;
                    Console.WriteLine("Best Result:" + bestValue);
                    for (int m = 0; m < resultValues.Count; m++)
                    {
                        Console.WriteLine("Item--> \t Value: " + resultValues[m] + "\t Weight: " + resultWeights[m]);
                    }
                    Console.WriteLine("\n\nTotal Value:" + totalValue + "    " + "Total Weight:" + counter + "\n");


                    for (int n = 1; n < values.Count; n++)
                    {
                        //status[i - 1] = 0;
                        Console.Write(status[n] + " ");
                        status[n] = 0;
                    }
                    Console.WriteLine("\n---------------------------\n");
                }
                else
                {
                    for (int n = 1; n < values.Count; n++)
                    {
                        status[n] = 0;
                    }
                }

            }

        }
    }
}
