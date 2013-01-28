using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InsertingLineNumber
{
    class InsertingLineNumber
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("../../output.txt");
            using (writer)
            {
                StreamReader reader = new StreamReader("../../input.txt");
                using (reader)
                {
                    string line = reader.ReadLine();
                    int index = 1;
                    while (line != null)
                    {
                        writer.WriteLine(index + " " + line);
                        line = reader.ReadLine();
                        index++;
                    }
                }
            }
        }
    }
}
