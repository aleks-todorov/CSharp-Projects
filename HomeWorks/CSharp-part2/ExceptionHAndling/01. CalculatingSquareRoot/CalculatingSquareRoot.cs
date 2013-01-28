using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculatingSquareRoot
{
    class CalculatingSquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                CheckForPossitiveNumber(number);
                int result = CalcSquareRoot(number);
                Console.WriteLine(result);

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
                Console.WriteLine("Entered number was negative. Please enter possitive value in orderto find square root!");
            }
            finally
            {
                Console.WriteLine("Good Bye!");
            }
        }

        private static void CheckForPossitiveNumber(int number)
        {
            if (number < 0)
            {
                throw new ArithmeticException();
            }
        }

        private static int CalcSquareRoot(int numbers)
        {
            int squareRoot = (int)Math.Sqrt((double)numbers);
            return squareRoot;
        }
    }
}
