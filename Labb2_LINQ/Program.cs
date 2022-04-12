

using Labb2_LINQ.Data;
using Labb2_LINQ.Data.Context;
using Labb2_LINQ.Data.Handlers;
using Labb2_LINQ.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Labb2_LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildHost();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                DataSeed.Initialize(services);
            }

            var handler = host.Services.GetRequiredService<IAppHandler>();
            handler.Run();
        }

        private static IHost BuildHost()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services = ConfigureServices(services);
                })
                .Build();
        }

        private static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(x =>
                x.UseSqlServer(
                    "Data Source=.\\SQLEXPRESS;Initial Catalog=LINQ;Integrated Security=True;"));

            services.AddTransient<IApplicationServices, ApplicationServices>();
            services.AddTransient<IAppHandler, AppHandler>();

            return services;
        }
    }

    
}

