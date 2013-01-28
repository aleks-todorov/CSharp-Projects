using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortingUsingBinSearch
{
    class SortingUsingBinSearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value for n:");
            int n = int.Parse(Console.ReadLine());
            int[] numArray = new int[n];
            Console.WriteLine("Please enter elements value:");
            for (int i = 0; i < n; i++)
            {
                numArray[n] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter value for k:");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(numArray);
            int possition = Array.BinarySearch(numArray, k);

            while (possition < 0)
            {
                k--;
                possition = Array.BinarySearch(numArray, k);
            }

            Console.WriteLine("Number {0} was found on possition: {1}", k, possition);
        }
    }
}
