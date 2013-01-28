using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FillingSeries
{
    class FillingSeries
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        CheckForNumberIngegrity(1, numbers[i]);
                    }
                    else
                    {
                        CheckForNumberIngegrity(numbers[i - 1], numbers[i]);
                    }
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid number! ");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Invalid Number!");
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine("Invalid Number");
            }
        }

        private static void CheckForNumberIngegrity(int previousValue, int number)
        {
            if (number <= previousValue || number >= 100)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
