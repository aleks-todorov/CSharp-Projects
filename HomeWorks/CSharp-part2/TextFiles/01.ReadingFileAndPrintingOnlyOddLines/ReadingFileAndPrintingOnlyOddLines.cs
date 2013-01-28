using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.ReadingFileAndPrintingOnlyOddLines
{
    class ReadingFileAndPrintingOnlyOddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../text.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                int index = 1;
                while (line != null)
                {
                    if (index % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    index++;
                }
            }
        }
    }
}
