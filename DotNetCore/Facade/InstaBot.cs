using System.Data.OleDb;
using System.Threading.Tasks;
using BotInstagram.DAO;
using BotInstagram.Models;
using BotInstagram.Service;

namespace BotInstagram.Facade
{
    public class InstaBot
    {
        private readonly string _credentialsPath;
        private readonly string _sheetId;
        private readonly string _rangeSheetValues;
        
        public InstaBot(string credentialsPath, string sheetId, string rangeSheetValues)
        {
            _credentialsPath = credentialsPath;
            _sheetId = sheetId;
            _rangeSheetValues = rangeSheetValues;
        }
        
        public async Task Execute(string promotionUrl, string user, string password, QtdPessoa qtdPessoa)
        {
            var datas = await new SheetsDAO(_credentialsPath, _sheetId).GetData(_rangeSheetValues);
            
            await new InstaBotService().ExecuteInstagram(promotionUrl, user, password, (int)qtdPessoa, datas);
        }
    }
}