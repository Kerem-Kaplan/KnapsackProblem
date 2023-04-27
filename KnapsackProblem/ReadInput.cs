using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    public class ReadInput
    {
        public List<UInt32> GetValue()
        {
            StreamReader streamReader = new StreamReader("D:/ÜNİVERSİTE/6.DÖNEM/Algoritma Analizi Ve Tasarımı/Ödevler/Ödev-2/ks_4_0");

            string line;

            line = streamReader.ReadLine();

            List<UInt32> values = new List<UInt32>();

            while (line != null)
            {
                string[] lineValues = line.Split(' ');
                //Console.WriteLine(lineValues[0] + "  " + lineValues[1]);
                values.Add(UInt32.Parse(lineValues[0]));
                line = streamReader.ReadLine();

            }

            streamReader.Close();
            return values;
        }

        public List<UInt32> GetWeight()
        {
            StreamReader streamReader = new StreamReader("D:/ÜNİVERSİTE/6.DÖNEM/Algoritma Analizi Ve Tasarımı/Ödevler/Ödev-2/ks_4_0");

            string line;

            line = streamReader.ReadLine();

            List<UInt32> weights = new List<UInt32>();

            while (line != null)
            {
                string[] lineValues = line.Split(' ');
                //Console.WriteLine(lineValues[0] + "  " + lineValues[1]);
                weights.Add(UInt32.Parse(lineValues[1]));
                line = streamReader.ReadLine();

            }

            streamReader.Close();
            return weights;
        }

       
    }
}

