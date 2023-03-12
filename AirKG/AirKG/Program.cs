using AirKG.Context;
using AirKG.Entity;
using AirKG.Extension;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirKG
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var serives = scope.ServiceProvider;
                try
                {
                    var context = serives.GetRequiredService<AirKGDbContext>();
                    
                    var userManger = serives.GetRequiredService<UserManager<User>>();
                    var rolesManager = serives.GetRequiredService<RoleManager<IdentityRole>>();
                    await Initialize.InitializeAsync(userManger, rolesManager);
                    await context.Seed(userManger, rolesManager);
                }
                catch (Exception ex)
                {
                    var logger = serives.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Error during db seed");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
