using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {

            var imp = new WCFServer("http://localhost:8001/");

            //string program = imp.GetMainInfo(null);
            Console.WriteLine("Service is running!");
            Console.ReadLine();

        }
    }
}
