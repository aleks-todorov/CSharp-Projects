using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FindingPrimes
{
    class FindingPrimes
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();
             for (int i = 1; i <= 10000000; i++)
            {
                if ((i % 2 == 0) || (i % 3 == 0) || (i % 5 == 0) || (i % 7 == 0))
               {
                   continue;
               }
               else
               {
                   primes.Add(i);
               }
            }

            /*foreach(var prime in primes)
                Console.WriteLine(prime);*/ //If somebody have spare time to lose-uncoment;
        }
    }
}
