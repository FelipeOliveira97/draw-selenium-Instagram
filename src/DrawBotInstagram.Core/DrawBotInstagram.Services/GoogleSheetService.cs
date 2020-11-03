using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrawBotInstagram.DAO.Interfaces;
using DrawBotInstagram.Models;
using DrawBotInstagram.Models.Settings;
using DrawBotInstagram.Services.Interfaces;

namespace DrawBotInstagram.Services
{
    public class GoogleSheetService : IGoogleSheetService
    {
        private readonly IGoogleSheetDAO _sheetDao;
        
        public GoogleSheetService(IGoogleSheetDAO sheetDao)
        {
            _sheetDao = sheetDao;
        }
        
        public async Task<IList<InstagramUser>> GetUserProfilesAsync(GoogleSheetSettings sheetSettings)
        {
            var sheetValues = await _sheetDao.GetSheetData(sheetSettings);

            IList<InstagramUser> instagramUsers = new List<InstagramUser>();

            foreach (var row in sheetValues)
            {
                var value = row.FirstOrDefault();
                
                instagramUsers.Add(new InstagramUser(value.ToString()));
            }

            return instagramUsers;
        }
    }
}
