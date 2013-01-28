using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculatingSumFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "43 68 9 23 318";
            string[] numbersArray = numbers.Split(' ');
            int totalSum = 0;
            foreach (var element in numbersArray)
            {
                totalSum += int.Parse(element);
            }
            Console.WriteLine(totalSum);
        }
    }
}
