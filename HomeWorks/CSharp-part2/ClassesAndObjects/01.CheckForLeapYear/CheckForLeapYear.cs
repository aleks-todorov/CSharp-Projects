using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CheckForLeapYear
{
    class CheckForLeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter year: ");
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Year: {0} was leap!", year);
            }
            else
            {
                Console.WriteLine("Year: {0} was NOT leap!", year);
            }

        }
    }
}
