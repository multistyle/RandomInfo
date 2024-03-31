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
        public GoogleCredential getCredential()
        {

            string fileName = "credentialsAuToData.json";
            string credentialsPath = new Common().getFilePath(fileName);

            // Chuỗi phạm vi truy cập (scope)
            string[] scopes = { SheetsService.Scope.Spreadsheets };

            // Xác thực và tạo phiên làm việc
            return GoogleCredential.FromFile(credentialsPath).CreateScoped(scopes);
        }

        public SheetsService getService()
        {
            // Tạo dịch vụ Sheets API
            return new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = getCredential(),
                ApplicationName = "AutoData"
            });
        }

        public ValueRange getData(string spreadsheetId, string sheetName, string rangeData, int startRow = 0, int endRow = 0)
        {
            ValueRange responseData;
            // Lấy giá trị từ phạm vi được chỉ định

            var requestData = getService().Spreadsheets.Values.Get(spreadsheetId, rangeData);
            responseData = requestData.Execute();
            return responseData;
        }

        public BatchUpdateValuesResponse UpdateData(string spreadsheetId, List<ValueRange> data)
        {
            // Cập nhật dữ liệu
            BatchUpdateValuesRequest request = new BatchUpdateValuesRequest
            {
                Data = data,
                ValueInputOption = "RAW"
            };

            SpreadsheetsResource.ValuesResource.BatchUpdateRequest updateRequest =
                getService().Spreadsheets.Values.BatchUpdate(request, spreadsheetId);

            return updateRequest.Execute();
        }
    }
}
