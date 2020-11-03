using System.Collections.Generic;
using DrawBotInstagram.Models;

namespace DrawBotInstagram.Services.Interfaces
{
    public interface IInstagramCrawlerService
    {
        void FactoryDriver();
        void InstagramLogin();
        bool IsLoggedInInstagram();
        void EnterPromotion();
        void PublishCommentUsersProfile(IList<InstagramUser> instagramUsers);
        void CloseDisposeDriver();
    }
}