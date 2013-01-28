using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.IndexOfElementWithBinarySearch
{
    class IndexOfElementWithBinarySearch
    {
        static void Main()
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Console.WriteLine("Please enter possition: ");
            int possition = int.Parse(Console.ReadLine());
            int low = 0;
            int high = array.Length - 1;
            int middlePossition = (low + high) / 2;
            while (low + 1 < high)
            {
                middlePossition = (low + high) / 2;
                if (possition < middlePossition)
                {
                    high = middlePossition;
                }
                else
                {
                    low = middlePossition;
                }
            }
            Console.WriteLine(low);
        }
    }
}
