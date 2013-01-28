using System;
using System.Linq;

namespace _05.SortingStringMatrixByElementLength
{
    class SortingStringMatrixByElementLength
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "a", "aaaaaa", "aaa", "aa", "aaaa", "aaaaa" };
            var sorterdArray = stringArray.OrderBy(x => x.Length);

            foreach (var element in sorterdArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
