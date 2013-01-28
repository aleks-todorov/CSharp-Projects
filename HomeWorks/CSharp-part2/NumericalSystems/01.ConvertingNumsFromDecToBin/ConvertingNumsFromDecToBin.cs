using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConvertingNumsFromDecToBin
{
    class ConvertingNumsFromDecToBin
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string binNumber = "";
            while (number > 0)
            {
                binNumber = number % 2 + binNumber;
                number /= 2;
            }
            Console.WriteLine(binNumber);
        }
    }
}
