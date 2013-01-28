using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CheckingDifferenceBetweenArrayElements
{
    public class CheckingDifferenceBetweenArrayElements
    {
        static void Main(string[] args)
        {
            int[] numbers = { 43, 4, 3, 23, 43, 4, 3, 234, 43, 23, 2, 43 };
            int possition = 7;
            if (possition < numbers.Length - 1 && possition > 0)
            {
                bool isBigger = CheckNeighbours(numbers, possition);
                if (isBigger == true)
                {
                    Console.WriteLine("Array element with possition {0} is bigger than its neighbours!", possition);
                }
                else
                {
                    Console.WriteLine("Is not bigger!");
                }
            }
            else
            {
                Console.WriteLine("Invalid possition!");
            }
        }

        public static bool CheckNeighbours(int[] numbers, int possition)
        {
            bool isBigger = true;
            if (possition > 0 && isBigger == true)
            {
                if (numbers[possition] < numbers[possition - 1])
                {
                    isBigger = false;
                }
            }
            if (possition < numbers.Length && isBigger == true)
            {
                if (numbers[possition] < numbers[possition + 1])
                {
                    isBigger = false;
                }
            }
            return isBigger;
        }
    }
}
