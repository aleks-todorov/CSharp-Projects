using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountingOccurenceOfNumberInArray
{
    public class CountingOccurenceOfNumberInArray
    {
        static void Main(string[] args)
        {
            int number = 4;
            int[] numberArray = { 1, 2, 3, 4, 5, 4, 34, 3, 4, 5, 6, 7, 4 };
            int count = CountOccurence(number, numberArray);
            Console.WriteLine(count);
        }

        public static int CountOccurence(int number, int[] numberArray)
        {
            int count = 0;
            foreach (var element in numberArray)
            {
                if (element == number)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
