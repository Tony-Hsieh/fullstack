using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MovieShopMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    //1. program.cs main method is the one that executes first=>
    //2. CreateHostBuilder "Kestral serveer" is a cross platform server(new in .Net Core)
    //3. Startup
    //4. Use this method to configure the HTTP request pipeline

    //ASP .Net Core has a concept called middleware

    //Broswer => localhaost/home/index GET =>
    //Order of the Middleware are very important
    //(see web doc)
}
