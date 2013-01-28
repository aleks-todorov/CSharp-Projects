using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.UsingVariableNumberOfArgOfMethod
{
    class UsingVariableNumberOfArgOfMethod
    {
        static void Main(string[] args)
        {
            CalculatingMinValue(2, 3, 4, 5, 6, 7, -34, -33, 65, -23, -78, 23, 34, 54, 6, 556);
            CalculatingMaxValue(2, 3, 4, 5, 6, 7, -34, -33, 65, -23, -78, 23, 34, 54, 6, 556);
            CalculatingAverageValue(2, 3, 4, 5, 6, 7, -34, -33, 65, -23, -78, 23, 34, 54, 6, 556);
            CalculatingSum(2, 3, 4, 5, 6, 7, -34, -33, 65, -23, -78, 23, 34, 54, 6, 556);
            CalculatingProduct(2, 3, 4, 5, 6, 7, -34, -33, 65, -23, -78, 23, 34, 54, 6, 556);
        }

        private static void CalculatingProduct(params int[] numbers)
        {
            long product = 1;
            foreach (var element in numbers)
            {
                product *= element;
            }
            Console.WriteLine("The product is: {0}", product);
        }

        private static void CalculatingSum(params int[] numbers)
        {
            decimal sum = 0;
            foreach (var element in numbers)
            {
                sum += element;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }

        private static void CalculatingAverageValue(params int[] numbers)
        {
            Console.WriteLine("The average value is: {0}", numbers.Average());
        }

        private static void CalculatingMaxValue(params int[] numbers)
        {
            Console.WriteLine("The maximum value is: {0}", numbers.Min());
        }

        private static void CalculatingMinValue(params int[] numbers)
        {
            Console.WriteLine("The minimum value is: {0}", numbers.Max());
        }

    }
}
