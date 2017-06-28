using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace KatanaDemo.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "http://localhost:8080";

            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine($"Listening on {uri}...");
                Console.ReadLine();
                Console.WriteLine("Shuting down...");
            }
        }
    }
}
