using System.Threading.Tasks;
using DrawBotInstagram.Models.Settings;

namespace DrawBotInstagram.Facades.Interfaces
{
    public interface IInstagramBotFacade
    {
        Task CommentUsersProfileInPromotion(GoogleSheetSettings sheetSettings);
    }
}