// using System.IO;
// using System.Threading;
// using System.Threading.Tasks;
// using Google.Apis.Auth.OAuth2;
// using Google.Apis.Services;
// using Google.Apis.Sheets.v4;
// using Google.Apis.Util.Store;

// namespace BotInstagram.Factory
// {
//     public static class SheetsFactory
//     {
//         static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        
//         public async static Task<SheetsService> GetSheetsConnection(string credentialsPath)
//         {
//             using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
//             {
//                 var credPath = "token.json";
                
//                 var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
//                     GoogleClientSecrets.Load(stream).Secrets,
//                     Scopes,
//                     "user",
//                     CancellationToken.None,
//                     new FileDataStore(credPath, true));

//                 return new SheetsService(new BaseClientService.Initializer
//                 {
//                     HttpClientInitializer = credential,
//                     ApplicationName = "BotInstagram"
//                 });
//             }
//         }
//     }
// }