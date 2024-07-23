using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetEnv;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NUglify.Helpers;

namespace Aled.OpenFoodFactService.HttpApi.Client.ConsoleTestApp;

class Program
{
    static async Task Main(string[] args)
    {
        await CreateHostBuilder(args).RunConsoleAsync();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .AddAppSettingsSecretsJson()
            .ConfigureServices((hostContext, services) =>
            {
                if (hostContext.HostingEnvironment.IsDevelopment())
                {
                    Env.Load();
                    
                    var envKeys = new Dictionary<string, string>
                    {
                        {"RemoteServices:Default:BaseUrl", "REMOTE_SERVICE_URL"},
                        {"IdentityClients:Default:Authority", "AUTH_SERVER_URL"},
                    };
                    
                    envKeys.ForEach(pair =>
                    {
                        var value =  Env.GetString(pair.Value);
                        
                        if (string.IsNullOrEmpty(value))
                        {
                            throw new Exception($"ConfigurationError: an error occured on {pair.Value} env key. Ensure the .env file is correctly configured and placed in the root directory.");
                        }
                        
                        hostContext.Configuration[pair.Key] = value;
                    });
                }
                
                services.AddHostedService<ConsoleTestAppHostedService>();
            });
}
