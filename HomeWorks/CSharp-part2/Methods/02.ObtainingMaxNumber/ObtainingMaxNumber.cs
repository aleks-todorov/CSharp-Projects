using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ObtainingMaxNumber
{
    class ObtainingMaxNumber
    {
        static void Main(string[] args)
        {
            int maxNumber = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Number: ");
                int number = int.Parse(Console.ReadLine());
                maxNumber = GetmaX(maxNumber, number);
            }
            Console.WriteLine("The Biggest Number is: {0}", maxNumber);
        }

        private static int GetmaX(int maxNumber, int number)
        {
            if (maxNumber < number)
            {
                maxNumber = number;
            }
            return maxNumber;
        }
    }
}
