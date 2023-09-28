using Core.Services;
using Core;
using DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace LegacySystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var serviceProvider = ConfigureServices();
            ApplicationConfiguration.Initialize();
            Application.Run(new Main(serviceProvider));
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<SqlDataAccess>();
            services.AddSingleton<ISqlDataAccess,SqlDataAccess>();
            services.AddSingleton<CarServices>();
            return services.BuildServiceProvider();
        }
    }
}