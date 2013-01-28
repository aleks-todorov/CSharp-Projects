using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddingPolinomials
{
    class AddingPolinomials
    {
        static void Main(string[] args)
        {
            int[] firstCoef = { 5, 0, 1 };
            int[] secondCoef = { 6, 3, 2 };
            AddingCoef(firstCoef, secondCoef);
        }

        private static void AddingCoef(int[] firstCoef, int[] secondCoef)
        {
            int[] finalCoef = { 0, 0, 0 };
            for (int i = 0; i < firstCoef.Length; i++)
            {
                finalCoef[i] = firstCoef[i] + secondCoef[i];
            }
            Console.Write("The coeficients after addition are: ");
            foreach (var coef in finalCoef)
            {
                Console.Write(coef + " ");
            }
            Console.WriteLine();     
        }
    }
}
