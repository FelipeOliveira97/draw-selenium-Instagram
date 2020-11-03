using System.IO;
using DrawBotInstagram.DAO;
using DrawBotInstagram.DAO.Interfaces;
using DrawBotInstagram.Models.Settings;
using DrawBotInstagram.Services.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium.Chrome;

namespace DrawBotInstagram.Services.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, GoogleSheetAuthSettings googleSheetSettings, ApplicationSettings applicationSettings)
        {
            services.AddSingleton(GetSheetsService(googleSheetSettings, applicationSettings));
            services.AddSingleton<IGoogleSheetDAO, GoogleSheetDAO>();
            services.AddSingleton<IGoogleSheetService, GoogleSheetService>();
            services.AddSingleton<IInstagramCrawlerService, InstagramCrawlerService>();
            
            return services;
        }

        private static SheetsService GetSheetsService(GoogleSheetAuthSettings sheetSettings, ApplicationSettings applicationSettings)
        {
            return new SheetsService(new BaseClientService.Initializer
            {
                ApplicationName = applicationSettings.Name,
                ApiKey = sheetSettings.ApiKey
            });
        }
    }
}