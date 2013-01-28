using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SequenceWithGivenSum
{
    class SequenceWithGivenSum
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int s = 11;
            int currentSum = 0;
            List<int> numbers = new List<int>();
            bool solutionFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (solutionFound == true)
                {
                    break;
                }
                currentSum = +array[i];
                numbers.Add(array[i]);
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    currentSum += array[j];
                    numbers.Add(array[j]);
                    if (currentSum == s)
                    {
                        solutionFound = true;
                        break;
                    }
                    else if (currentSum < s)
                    {
                        continue;
                    }
                    else
                    {
                        numbers.Clear();
                        currentSum = 0;
                        break;
                    }
                }
            }
            if (solutionFound == true)
            {
                foreach (var element in numbers)
                {
                    Console.WriteLine(element);
                }
            }
            else
            {
                Console.WriteLine("No solution");
            }
        }
    }
}
