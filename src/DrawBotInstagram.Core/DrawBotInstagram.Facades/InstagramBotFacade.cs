using System;
using System.Threading.Tasks;
using DrawBotInstagram.Facades.Interfaces;
using DrawBotInstagram.Models.Settings;
using DrawBotInstagram.Services.Interfaces;

namespace DrawBotInstagram.Facades
{
    public class InstagramBotFacade : IInstagramBotFacade
    {
        private readonly IGoogleSheetService _sheetService;
        
        public InstagramBotFacade(IGoogleSheetService sheetService)
        {
            _sheetService = sheetService;
        }
        
        public async Task ExecuteAsync(GoogleSheetSettings sheetSettings)
        {
            var users = await _sheetService.GetUserProfilesAsync(sheetSettings);
        }
    }
}
