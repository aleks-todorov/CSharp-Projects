using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FindingMostCommonNumber
{
    class FindingMostCommonNumber
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int currentNumber = 0;
            int mostFrequentNumber = 0;
            int occurence = 1;
            int maxOccurance = 1;
            Array.Sort(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                currentNumber = array[i];
                if (currentNumber == array[i + 1])
                {
                    occurence++;
                    continue;
                }
                if (occurence > maxOccurance)
                {
                    maxOccurance = occurence;
                    mostFrequentNumber = array[i - 1];
                }
                occurence = 1;
            }

            Console.WriteLine("Number {0} occured {1} times", mostFrequentNumber, maxOccurance);
        }
    }
}
