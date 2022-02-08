using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace SearchEngine
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //by xxx
                    IConfigurationSection section = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ApplicationUrl");
                    webBuilder.UseUrls(section.Value);

                    webBuilder.UseStartup<Startup>();
                });
    }
}
