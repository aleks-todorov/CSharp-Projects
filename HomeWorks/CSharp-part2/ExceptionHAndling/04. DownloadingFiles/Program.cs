using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04.DownloadingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "Logo-BASD.jpg");
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("You don't have sufficient space on the HDD");
            }
            catch (AccessViolationException)
            {
                Console.WriteLine("You don't have sufficient rights.Contact your administrator");
            }
            catch (System.Net.WebException)
            {
                Console.WriteLine("There was an error with remote server. Please check the file name and/or full path!");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("There was an error with the request for download!");
            }
        }
    }
}
