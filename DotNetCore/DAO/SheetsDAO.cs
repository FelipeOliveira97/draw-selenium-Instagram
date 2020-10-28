using System.Collections.Generic;
using System.Data.OleDb;
using System.Threading.Tasks;
using BotInstagram.Factory;
using Google.Apis.Sheets.v4;

namespace BotInstagram.DAO
{
    public class SheetsDAO
    {
        private readonly string _credentialsPath;
        private readonly string _spreadsheetId;
        
        public SheetsDAO(string credentialsPath, string spreadsheetId)
        {
            _credentialsPath = credentialsPath;
            _spreadsheetId = spreadsheetId;
        }

        public async Task<IList<IList<object>>> GetData(string range)
        {
            var service = await GetSheets();

            var request = service.Spreadsheets.Values.Get(_spreadsheetId, range);

            var response = await request.ExecuteAsync();

            return response.Values;
        }

        private async Task<SheetsService> GetSheets()
        {
            return await SheetsFactory.GetSheetsConnection(_credentialsPath);
        }
    }
}