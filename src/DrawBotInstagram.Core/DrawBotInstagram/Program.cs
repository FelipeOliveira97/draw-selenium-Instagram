using System.ComponentModel;
using System.IO;
using DrawBotInstagram.Facades;
using DrawBotInstagram.Facades.Interfaces;
using DrawBotInstagram.Models.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BotInstagram
{
    class Program
    {
        private const string APP_SETTINGS_FILE = "appsettings.json";
        private const string APPLICATION_JSON_SECTION = "Application";
        private const string GOOGLE_SHEET_JSON_SECTION = "GoogleSheet";
        private const string GOOGLE_SHEET_AUTH_JSON_SECTION = "Authorization";
        
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            var configuration = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile(APP_SETTINGS_FILE)
                                        .Build();

            ConfigureServices(serviceCollection, configuration);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var instagramFacade = serviceProvider.GetService<IInstagramBotFacade>();

            instagramFacade.ExecuteAsync(serviceProvider.GetService<GoogleSheetSettings>()).Wait();
        }

        private static void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration)
        {
            var applicationSettings = configuration.GetSection(APPLICATION_JSON_SECTION).Get<ApplicationSettings>();
            var googleSettings = configuration.GetSection(GOOGLE_SHEET_JSON_SECTION).Get<GoogleSheetSettings>();
            var googleAuthSettings = configuration.GetSection(GOOGLE_SHEET_JSON_SECTION).GetSection(GOOGLE_SHEET_AUTH_JSON_SECTION).Get<GoogleSheetAuthSettings>();
            
            services.AddOptions();
            
            services.AddSingleton(googleSettings);

            services.AddApplicationServices(googleAuthSettings, applicationSettings);
        }
    }
}
