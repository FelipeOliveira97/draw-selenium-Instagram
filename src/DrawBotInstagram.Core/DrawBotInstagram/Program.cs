using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using DrawBotInstagram.Facades.Extensions;
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
        private const string SELENIUM_JSON_SECTION = "Selenium";
        private const string INSTAGRAM_JSON_SECTION = "Instagram";
        private const string GOOGLE_SHEET_AUTH_JSON_SECTION = "Authorization";
        
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            var serviceCollection = new ServiceCollection();

            var configuration = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile(APP_SETTINGS_FILE)
                                        .Build();

            ConfigureServices(serviceCollection, configuration);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var instagramFacade = serviceProvider.GetService<IInstagramBotFacade>();
            
            await instagramFacade.ExecuteAsync(serviceProvider.GetService<GoogleSheetSettings>());
        }

        private static void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration)
        {
            var applicationSettings = configuration.GetSection(APPLICATION_JSON_SECTION).Get<ApplicationSettings>();
            var googleSettings = configuration.GetSection(GOOGLE_SHEET_JSON_SECTION).Get<GoogleSheetSettings>();
            var googleAuthSettings = configuration.GetSection(GOOGLE_SHEET_JSON_SECTION).GetSection(GOOGLE_SHEET_AUTH_JSON_SECTION).Get<GoogleSheetAuthSettings>();
            var seleniumDriverSettings = configuration.GetSection(SELENIUM_JSON_SECTION).Get<SeleniumDriverSettings>();
            var instagramUserSettings = configuration.GetSection(INSTAGRAM_JSON_SECTION).Get<InstagramUserSettings>();
            
            services.AddOptions();
            
            services.AddSingleton(googleSettings);
            services.AddSingleton(instagramUserSettings);
            services.AddSingleton(seleniumDriverSettings);

            services.AddApplicationServices(googleAuthSettings, applicationSettings);
        }
    }
}
