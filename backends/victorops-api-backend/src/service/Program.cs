using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace VictorOpsBackendApi
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
                    webBuilder
                    .ConfigureAppConfiguration((builderContext, configurationBuilder) =>
                    {
                        configurationBuilder.AddEnvironmentVariables();
                        configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
                        // Use this file to pass in dynamic configuration
                        configurationBuilder.AddIniFile("app/config.ini", optional: true, reloadOnChange: true);
                    })
                    .ConfigureServices((builderContext, services) =>
                    {
                        services.AddOptions();
                        services.Configure<AppConfiguration>(builderContext.Configuration);
                    })
                    .UseStartup<Startup>();
                });
    }
}
