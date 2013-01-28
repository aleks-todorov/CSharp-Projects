using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FindingFirstBiggerElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 43, 4, 3, 23, 43, 4, 3, 234, 43, 23, 2, 43 };
            int possition = FindFirstBiggestElement(numbers);
            Console.WriteLine(possition);

        }

        private static int FindFirstBiggestElement(int[] numbers)
        {
            int possition = 1;
            for (possition = 1; possition < numbers.Length - 1; possition++)
            {
                bool isBigger = CheckingDifferenceBetweenArrayElements.CheckingDifferenceBetweenArrayElements.CheckNeighbours(numbers, possition);
                if (isBigger == true)
                {
                    break;
                }
            }
            return possition;
        }
    }
}
