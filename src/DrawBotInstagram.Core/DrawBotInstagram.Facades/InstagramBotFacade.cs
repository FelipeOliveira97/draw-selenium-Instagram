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
        private readonly IInstagramCrawlerService _instagramService;
        
        public InstagramBotFacade(IGoogleSheetService sheetService, IInstagramCrawlerService instagramService)
        {
            _sheetService = sheetService;
            _instagramService = instagramService;
        }
        
        public async Task CommentUsersProfileInPromotion(GoogleSheetSettings sheetSettings)
        {
            var users = await _sheetService.GetUserProfilesAsync(sheetSettings);

            try
            {
                _instagramService.FactoryDriver();
                
                _instagramService.InstagramLogin();

                if (_instagramService.IsLoggedInInstagram())
                {
                    _instagramService.EnterPromotion();

                    _instagramService.PublishCommentUsersProfile(users);
                }
            }
            finally
            {
                _instagramService.CloseDisposeDriver();
            }
        }
    }
}
