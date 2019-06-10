using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MVCCoreAppExample
{
   public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().InitializeDB().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}





