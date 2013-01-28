using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.OperationsWithPolinomials
{
    class OperationsWithPolinomials
    {
        static void Main(string[] args)
        {
            int[] firstCoef = { 5, 0, 1 };
            int[] secondCoef = { 6, 3, 2 };
            SubtractingCoef(firstCoef, secondCoef);
            Multiplication(firstCoef, secondCoef);

        }

        private static void Multiplication(int[] firstCoef, int[] secondCoef)
        {
            int[] finalCoef = { 0, 0, 0 };
            for (int i = 0; i < firstCoef.Length; i++)
            {
                finalCoef[i] = firstCoef[i] * secondCoef[i];
            }
            Console.Write("The coeficients after multiplication are: ");
            foreach (var coef in finalCoef)
            {
                Console.Write(coef + " ");
            }
            Console.WriteLine();
        }

        private static void SubtractingCoef(int[] firstCoef, int[] secondCoef)
        {
            int[] finalCoef = { 0, 0, 0 };
            for (int i = 0; i < firstCoef.Length; i++)
            {
                finalCoef[i] = firstCoef[i] - secondCoef[i];
            }
            Console.Write("The coeficients after subtraction are: ");
            foreach (var coef in finalCoef)
            {
                Console.Write(coef + " ");
            }
            Console.WriteLine();
        }
    }
}
