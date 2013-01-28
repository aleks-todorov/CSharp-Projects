using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.PrintingAllVariations
{
    class PrintingAllVariationsOfNumbers
    {
        static void Main(string[] args)
        {
            int k = 4;
            int n = 4;
            int[] numbers = new int[k];
            int startValue = k -1;
            GenerateNumbers(k -1, numbers, n, startValue);
        }

        static void GenerateNumbers(int k, int[] numbers, int n, int startValue)
        {

            if (startValue == -1)
            {
                PrintSequence(numbers);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    numbers[k - startValue] = i;
                    GenerateNumbers(k, numbers, n, startValue - 1);
                }
            }
        }

        private static void PrintSequence(int[] numbers)
        {
            foreach (var element in numbers)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
