using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DeletingOddLines
{
    class DeletingOddLines
    {
        static void Main(string[] args)
        {
            List<string> evenLines = new List<string>();
            WriteLines(ReadLines(evenLines));
        }

        private static void WriteLines(List<string> evenLines)
        {
            StreamWriter writer = new StreamWriter("../../text.txt", false);
            using (writer)
            {
                foreach (var line in evenLines)
                    writer.WriteLine(line);
            }
        }

        private static List<string> ReadLines(List<string> evenLines)
        {
            StreamReader reader = new StreamReader("../../text.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                int index = 1;
                while (line != null)
                {
                    if (index % 2 == 0)
                    {
                        evenLines.Add(line);
                    }
                    line = reader.ReadLine();
                    index++;
                }
            }
            return evenLines;
        }
    }
}
