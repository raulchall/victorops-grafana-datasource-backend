using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;

namespace VictorOpsBackendApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Setup the log level. Defaults to Error
            var logEventLevel = LogEventLevel.Error;
            if (!Enum.TryParse(Environment.GetEnvironmentVariable("LogLevel"), false, out logEventLevel))
            {
                logEventLevel = LogEventLevel.Error;
            }
            
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Is(logEventLevel)
                .Enrich.FromLogContext()
                .WriteTo.Console(
                    outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}")
                .CreateLogger();

            try
            {
                Log.Information("Starting App...");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "App terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
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
                })
                .UseSerilog();
    }
}
