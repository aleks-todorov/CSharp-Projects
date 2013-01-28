using System;
using System.Linq;

namespace _06.FindingMaximalSum
{
    class FindingMaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter K: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Please enter elements value: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            int biggestSum = 0;
            Console.WriteLine("The elements are: ");
            for (int i = array.Length-1; i >= array.Length - k; i--)
            {
                biggestSum += array[i];
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine("And the sum is: {0}", biggestSum);
        }
    }
}
