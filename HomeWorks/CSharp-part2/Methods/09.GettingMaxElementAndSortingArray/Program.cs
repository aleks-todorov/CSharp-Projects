using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.GettingMaxElementAndSortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 23, 4, 34, 3, 54, 65, 675, 435, 45, 5, 45, 4, 645 };
            int startIndex = 4;
            int endIndex = 8;
            int[] sortedNumbers = new int[endIndex - startIndex];
            int counter = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                sortedNumbers[counter] = numbers[i];
                counter++;
            }
            Array.Sort(sortedNumbers);
            Console.WriteLine("The biggest number in range {0} and {1} is: {2}", startIndex, endIndex, sortedNumbers.Max());
            counter = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                numbers[i] = sortedNumbers[counter];
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("Sorted(in this range) Array: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
