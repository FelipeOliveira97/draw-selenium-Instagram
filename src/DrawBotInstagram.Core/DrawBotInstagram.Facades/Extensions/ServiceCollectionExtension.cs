using DrawBotInstagram.Facades.Interfaces;
using DrawBotInstagram.Models.Settings;
using DrawBotInstagram.Services.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace DrawBotInstagram.Facades
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, GoogleSheetAuthSettings googleSheetSettings, ApplicationSettings applicationSettings)
        {
            services.AddSingleton<IInstagramBotFacade, InstagramBotFacade>();
            
            services.AddDataAccessServices(googleSheetSettings, applicationSettings);
            
            return services;
        }
    }
}