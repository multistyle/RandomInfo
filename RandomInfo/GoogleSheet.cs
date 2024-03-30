using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomInfo
{
    public class GoogleSheet
    {

        //public void AddDataToGoogleSheets(string spreadsheetId, string sheetName)
        //{

        //    // Mảng định nghĩa các trường thông tin
        //    string[] fields = { "Field1", "Field2", "Field3" };

        //    // Tạo Google Sheets API service
        //    SheetsService service = CreateSheetsService();

        //    // Lấy danh sách các cột hiện có trên sheet
        //    IList<Column> columns = GetColumns(service, spreadsheetId, sheetName);

        //    // Tìm vị trí dòng bắt đầu thêm dữ liệu (ví dụ: bắt đầu từ dòng 2)
        //    int startRow = 2;

        //    // Chuyển đổi mảng các trường thông tin thành đối tượng ValueRange
        //    ValueRange valueRange = new ValueRange
        //    {
        //        Values = new List<IList<object>> { new List<object>(fields) }
        //    };

        //    // Xác định vùng dữ liệu cần thêm
        //    string range = $"{sheetName}!A{startRow}";

        //    // Thực hiện thêm dữ liệu vào Google Sheets
        //    AppendValues(service, spreadsheetId, range, valueRange);
        //}

        //private SheetsService CreateSheetsService()
        //{

        //    // Đường dẫn đến file thông tin xác thực (credentials) của Google Sheets API
        //    string fileName = "credentialsAuToData.json";

        //    string currentDirectory = Directory.GetCurrentDirectory();

        //    string credentialsPath = Path.Combine(currentDirectory, fileName);

        //    GoogleCredential credential;

        //    using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
        //    {
        //        credential = GoogleCredential.FromStream(stream)
        //            .CreateScoped(SheetsService.Scope.Spreadsheets);
        //    }

        //    var applicationName = AppSetting.GetAppSettingValue("AutoData");

        //    return new SheetsService(new BaseClientService.Initializer()
        //    {
        //        HttpClientInitializer = credential,
        //        ApplicationName = string.IsNullOrEmpty(applicationName) ? "AutoData" : applicationName
        //    });
        //}

        //private IList<Column> GetColumns(SheetsService service, string spreadsheetId, string sheetName)
        //{
        //    // Lấy thông tin về danh sách các cột trên sheet
        //    SpreadsheetsResource.ValuesResource.GetRequest request =
        //        service.Spreadsheets.Values.Get(spreadsheetId, $"{sheetName}!A1:Z1");
        //    ValueRange response = request.Execute();
        //    IList<IList<object>> values = response.Values;

        //    // Tạo danh sách các cột từ dữ liệu vừa lấy được
        //    IList<Column> columns = new List<Column>();

        //    if (values != null && values.Count > 0)
        //    {
        //        for (int i = 0; i < values[0].Count; i++)
        //        {
        //            string columnName = Convert.ToString(values[0][i]);
        //            columns.Add(new Column { Name = columnName, Index = i + 1 });
        //        }
        //    }

        //    return columns;
        //}

        //private void AppendValues(SheetsService service, string spreadsheetId, string range, ValueRange valueRange)
        //{
        //    // Thực hiện thêm dữ liệu vào Google Sheets
        //    SpreadsheetsResource.ValuesResource.AppendRequest request =
        //        service.Spreadsheets.Values.Append(valueRange, spreadsheetId, range);
        //    request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
        //    AppendValuesResponse response = request.Execute();
        //}
    }
}
