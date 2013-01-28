using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.ReadingFile
{
    class ReadingFile
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader(@"C:\WINDOWS\win.ini");
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
            catch (System.AccessViolationException)
            {
                Console.WriteLine("You do not have admin rights on the PC. Please log on with adming credentials or contact your administrator.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Requested file was not found!");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("The file is too big and cannot be read!");
            }

        }
    }
}
