using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ComparingTwoTextFiles
{
    class ComparingTwoTextFiles
    {
        static void Main(string[] args)
        {
            StreamReader reader1 = new StreamReader("../../text1.txt");
            StreamReader reader2 = new StreamReader("../../text2.txt");
            int sameLines = 0;
            int differentLines = 0;
            using (reader1)
            {
                using (reader2)
                {
                    string contentOne = reader1.ReadLine();
                    string contentTwo = reader2.ReadLine();
                    while (contentOne != null)
                    {
                        if (contentOne == contentTwo)
                        {
                            sameLines++;
                        }
                        else
                        {
                            differentLines++;
                        }
                        contentOne = reader1.ReadLine();
                        contentTwo = reader2.ReadLine();
                    }
                }
            }
            Console.WriteLine(sameLines + " " + differentLines);
        }
    }
}
