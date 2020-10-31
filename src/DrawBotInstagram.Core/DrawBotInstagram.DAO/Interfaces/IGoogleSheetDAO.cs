using System.Collections.Generic;
using System.Threading.Tasks;
using DrawBotInstagram.Models.Settings;

namespace DrawBotInstagram.DAO.Interfaces
{
    public interface IGoogleSheetDAO
    {
        Task<IList<IList<object>>> GetSheetData(GoogleSheetSettings sheetSettings);
    }
}