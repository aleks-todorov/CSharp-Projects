using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReversingDigits
{
    public class ReversingDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            int reversed = ReverseNumber(number);
            Console.WriteLine(reversed);
        }

        public static int ReverseNumber(int number)
        {
            string reversed = string.Empty;
            while (number > 0)
            {
                reversed += number % 10;
                number /= 10;
            }
            return int.Parse(reversed);
        }
    }
}
