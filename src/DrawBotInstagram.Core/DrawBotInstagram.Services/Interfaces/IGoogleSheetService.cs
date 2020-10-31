using System.Collections.Generic;
using System.Threading.Tasks;
using DrawBotInstagram.Models;
using DrawBotInstagram.Models.Settings;

namespace DrawBotInstagram.Services.Interfaces
{
    public interface IGoogleSheetService
    {
        Task<IList<InstagramUser>> GetUserProfilesAsync(GoogleSheetSettings sheetSettings);
    }
}