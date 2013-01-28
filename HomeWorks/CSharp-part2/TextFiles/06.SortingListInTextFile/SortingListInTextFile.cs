using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SortingListInTextFile
{
    class SortingListInTextFile
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../input.txt");
            List<string> names = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    names.Add(line);
                    line = reader.ReadLine();
                }
            }
            names.Sort();
            StreamWriter writer = new StreamWriter("../../output.txt");
            using (writer)
            {
                foreach (var name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }
    }
}
