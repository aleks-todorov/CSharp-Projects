using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindingFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number [1...100]");
            int number = int.Parse(Console.ReadLine());
            BigInteger numberFactoriel = 1;
            for (int i = number; i > 0; i--)
            {
                numberFactoriel = numberFactoriel * i;
            }
            Console.WriteLine(numberFactoriel);
        }
    }
}
