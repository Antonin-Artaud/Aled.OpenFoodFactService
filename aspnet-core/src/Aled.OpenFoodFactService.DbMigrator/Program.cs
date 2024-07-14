using System;
using System.Threading.Tasks;
using DotNetEnv;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;

namespace Aled.OpenFoodFactService.DbMigrator;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Volo.Abp", LogEventLevel.Warning)
#if DEBUG
            .MinimumLevel.Override("Aled.OpenFoodFactService", LogEventLevel.Debug)
#else
                .MinimumLevel.Override("Aled.OpenFoodFactService", LogEventLevel.Information)
#endif
            .Enrich.FromLogContext()
            .WriteTo.Async(c => c.File("Logs/logs.txt"))
            .WriteTo.Async(c => c.Console())
            .CreateLogger();

        await CreateHostBuilder(args).RunConsoleAsync();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .AddAppSettingsSecretsJson()
            .ConfigureLogging((context, logging) => logging.ClearProviders())
            .ConfigureServices((hostContext, services) =>
            {
                if (hostContext.HostingEnvironment.IsDevelopment())
                {
                    Env.Load();

                    var openIddictAppRootUrl =
                        Env.GetString("API_HOST_URL");

                    if (string.IsNullOrEmpty(openIddictAppRootUrl))
                    {
                        throw new Exception($"ConfigurationError: an error occured on API_HOST_URL env key. Ensure the .env file is correctly configured and placed in the root directory.");
                    }
                    
                    hostContext.Configuration["OpenIddict:Applications:OpenFoodFactService_Swagger:RootUrl"] = openIddictAppRootUrl;
                }
                
                services.AddHostedService<DbMigratorHostedService>();
            });
    }
}