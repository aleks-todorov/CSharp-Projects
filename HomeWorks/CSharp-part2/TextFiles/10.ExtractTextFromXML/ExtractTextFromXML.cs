using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtractTextFromXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../input.txt");
            List<string> text = new List<string>();
            string content = string.Empty;
            using (reader)
            {
                content = reader.ReadToEnd();
            }

        }
    }
}
