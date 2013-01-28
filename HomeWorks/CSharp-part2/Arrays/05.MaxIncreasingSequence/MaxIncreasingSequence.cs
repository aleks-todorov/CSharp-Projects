using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.MaxIncreasingSequence
{
    class MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 3, 4, 5, 6, 7, 2, 2, 4 };
            List<int> currentSeries = new List<int>();
            List<int> maxSeries = new List<int>();
            int maxLength = 1;
            int currentLength = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + 1 == array[i + 1])
                {
                    currentSeries.Add(array[i]);
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxSeries = currentSeries.ToList();
                        continue;
                    }
                }
                if (currentLength == maxLength)
                {
                    maxSeries.Add(array[i]);
                }
                currentSeries.Clear();
                currentLength = 1;
            }
            foreach (var element in maxSeries)
            {
                Console.Write(element + " ");
            }
        }
    }
}

