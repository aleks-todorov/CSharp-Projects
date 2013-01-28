using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RepresentingShortAsBin
{
    class RepresentingShortAsBin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter valid short number: (-32768 to 32767)");
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2)); // Used to Compare the Result 
            string binNumber = "";
            if (number >= 0)
            {
                while (number > 0)
                {
                    binNumber = number % 2 + binNumber;
                    number /= 2;
                }
            }
            else
            {
                number = (short)(short.MinValue + number);
                while (number > 0)
                {
                    binNumber = number % 2 + binNumber;
                    number /= 2;
                }
                binNumber = 1 + binNumber;
            }
            Console.WriteLine(binNumber);
        }
    }
}
