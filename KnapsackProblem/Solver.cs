using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    public class Solver
    {


        public void SolvingResult()
        {
            ReadInput readInput = new();//sınıfın türetilmesi

            List<UInt32> values = readInput.GetValue(); //value değeri alınıyor
            List<UInt32> weights = readInput.GetWeight(); //weight değeri alınıyor

            var maxWeight = weights[0];     //maksimum weight değeri ataması

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
                var counterWeight = 0.0;
                List<UInt32> resultValues = new();
                List<UInt32> resultWeights = new();

                if (weights[i] <= maxWeight)    //ilk eklenecek item'ın toplam ağırlıktan büyük
                                                //olması kontrolü
                {
                    resultValues.Add(values[i]);    //ilk value eklenmesi
                    resultWeights.Add(weights[i]);  //ilk weight eklenmesi
                    counterWeight += weights[i];    //ilk eklenen item'ın ağırlığının atanması
                    totalValue += (values[i]);      //ilk eklenen item'ın değerinin atanması
                    status[i] = 1;                  //eklenen item'ın değerinin 1 yapılması
                }

                for (int j = i + 1; j < weights.Count; j++) //ilk eklenen itemden sonraki itemlerin eklenmesi
                {
                    if (counterWeight <= maxWeight)     //eklenecek item'ın toplam ağırlıkla karşılaştırışması
                    {
                        counterWeight += weights[j];
                        if (counterWeight > maxWeight)
                        {
                            status[j] = 0;
                            counterWeight -= weights[j];
                        }
                        else
                        {
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
                    Console.WriteLine(bestValue);

                    for (int n = 1; n < values.Count; n++)
                    {
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
