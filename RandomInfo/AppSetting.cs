using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace RandomInfo
{
    public class AppSetting
    {

        // Đường dẫn đến file appsettings.json
        public string appSettingsPath = new Common().getFilePath("appsettings.json");

        public void UpdateAppSetting(string key, string value)
        {
            if (File.Exists(appSettingsPath))
            {
                // Đọc nội dung file appsettings.json
                string json = File.ReadAllText(appSettingsPath);

                // Kiểm tra nếu file rỗng
                if (string.IsNullOrEmpty(json))
                {
                    // Tạo một đối tượng mới để lưu trữ các cặp key-value
                    dynamic appSettings = new JObject();
                    appSettings[key] = value;

                    // Chuyển đổi đối tượng dynamic thành chuỗi json
                    string updatedJson = JsonConvert.SerializeObject(appSettings, Formatting.Indented);

                    // Ghi lại nội dung json vào file appsettings.json
                    File.WriteAllText(appSettingsPath, updatedJson);
                }
                else
                {
                    // Chuyển đổi nội dung json thành đối tượng dynamic
                    dynamic appSettings = JsonConvert.DeserializeObject(json);

                    // Kiểm tra xem key đã tồn tại trong appSettings chưa
                    if (appSettings.ContainsKey(key))
                    {
                        appSettings[key] = value;
                    }
                    else
                    {
                        // Thêm key mới với giá trị value
                        appSettings.Add(key, value);
                    }

                    // Chuyển đổi đối tượng dynamic thành chuỗi json
                    string updatedJson = JsonConvert.SerializeObject(appSettings, Formatting.Indented);

                    // Ghi lại nội dung json vào file appsettings.json
                    File.WriteAllText(appSettingsPath, updatedJson);
                }
            }
        }

        public string GetAppSettingValue(string key)
        {
            if (File.Exists(appSettingsPath))
            {
                // Đọc nội dung file appsettings.json
                string json = File.ReadAllText(appSettingsPath);

                // Kiểm tra nếu nội dung JSON là null hoặc rỗng
                if (!string.IsNullOrEmpty(json))
                {
                    // Chuyển đổi nội dung json thành đối tượng dynamic
                    dynamic appSettings = JsonConvert.DeserializeObject(json);

                    // Kiểm tra xem key có tồn tại trong appSettings không
                    if (appSettings != null && appSettings.ContainsKey(key))
                    {
                        return appSettings[key].ToString();
                    }
                }
            }

            return string.Empty;
        }
    }
}
