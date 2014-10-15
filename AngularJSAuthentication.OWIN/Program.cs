using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSAuthentication.OWIN
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<AngularJSAuthentication.API.Startup>(url: baseAddress))
            {

                Console.WriteLine("Pres <ESC> to finish service.");
                while (Console.ReadKey().Key != ConsoleKey.Escape) { }
                Console.WriteLine("Exiting...");

            }

        }
    }
}
