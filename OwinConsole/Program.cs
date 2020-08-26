using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OwinConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:5000/";

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                HttpClient client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/Users").Result;

                Console.WriteLine(response);
                //Console.WriteLine(response.Content.ReadAsStringAsync().Result);
              
                Console.ReadLine();
            }
        }
    }
}
