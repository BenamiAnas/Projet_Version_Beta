using Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace Projet_Version_Beta
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
                })
            .ConfigureServices((hostContext, services) =>
            {
                // Retrieve connection string from appsettings.json
                var connectionString = hostContext.Configuration.GetConnectionString("DefaultConnection");

                // Register DbContext with PostgreSQL
                services.AddDbContext<AppDbContext>(options =>
                    options.UseNpgsql(connectionString));
            });


    }
}
