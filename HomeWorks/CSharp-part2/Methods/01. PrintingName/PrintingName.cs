using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingName
{
    public class PrintingName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter name: ");
            string name = Console.ReadLine();
            GetName(name);
        }

        public static string GetName(string name)
        {
            string result = "Hello, " + name + "!";
            Console.WriteLine(result);
            return result;

        }
    }
}

