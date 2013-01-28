using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReplacingSubstrings
{
    class ReplacingSubstrings
    {
        static void Main(string[] args)
        {
            string content = string.Empty;
            StreamWriter writer = new StreamWriter("../../output.txt");
            using (writer)
            {
                StreamReader reader = new StreamReader("../../input.txt");
                using (reader)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        line = line.Replace("start", "finish");
                        writer.Write(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
