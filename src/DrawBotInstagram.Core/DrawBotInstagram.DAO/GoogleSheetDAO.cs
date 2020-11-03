using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrawBotInstagram.DAO.Interfaces;
using DrawBotInstagram.Models.Settings;
using Google.Apis.Sheets.v4;

namespace DrawBotInstagram.DAO
{
    public class GoogleSheetDAO : IGoogleSheetDAO
    {
        private readonly SheetsService _sheetsService;
        
        public GoogleSheetDAO(SheetsService sheetsService)
        {
            _sheetsService = sheetsService;
        }
        
        public async Task<IList<IList<object>>> GetSheetData(GoogleSheetSettings sheetSettings)
        {
            // How values should be represented in the output.
            // The default render option is ValueRenderOption.FORMATTED_VALUE.
            SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum valueRenderOption = (SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum) 0;  // TODO: Update placeholder value.

            // How dates, times, and durations should be represented in the output.
            // This is ignored if value_render_option is
            // FORMATTED_VALUE.
            // The default dateTime render option is [DateTimeRenderOption.SERIAL_NUMBER].
            SpreadsheetsResource.ValuesResource.GetRequest.DateTimeRenderOptionEnum dateTimeRenderOption = (SpreadsheetsResource.ValuesResource.GetRequest.DateTimeRenderOptionEnum) 0;  // TODO: Update placeholder value.

            SpreadsheetsResource.ValuesResource.GetRequest request = _sheetsService.Spreadsheets.Values.Get(sheetSettings.SheetId, sheetSettings.Range);
            request.ValueRenderOption = valueRenderOption;
            request.DateTimeRenderOption = dateTimeRenderOption;

            var response = await request.ExecuteAsync();

            return response.Values;
        }
    }
}
