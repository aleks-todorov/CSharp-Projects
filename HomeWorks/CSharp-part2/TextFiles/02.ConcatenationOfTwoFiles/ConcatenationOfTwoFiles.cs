using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConcatenationOfTwoFiles
{
    class ConcatenationOfTwoFiles
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("../../file3.txt");
            using (writer)
            {
                string content = string.Empty;
                StreamReader reader = new StreamReader("../../file1.txt");
                using (reader)
                {
                    content = reader.ReadToEnd();
                }
                writer.Write(content);
                reader = new StreamReader("../../file2.txt");
                using (reader)
                {
                    content = reader.ReadToEnd();
                }
                writer.Write(content);
            }
        }
    }
}
