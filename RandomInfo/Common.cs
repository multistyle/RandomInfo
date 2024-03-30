using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Caching;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace RandomInfo
{
    public class Common
    {

        // Khởi tạo bộ nhớ cache
        public  MemoryCache cache = MemoryCache.Default;
       public const string cacheFistKey = "ListFirstName";
       public const string fistNamePath = "ListFirstName.txt";
       public const string lastNamePath = "ListLastName.txt";
       public const string cacheLastKey = "ListLastName";
       public const string listPhoneDataFileName = "ListPhoneData.txt";
       public const string keycachePhoneData = "ListPhoneData";

        DateTimeOffset cacheTime = DateTimeOffset.MaxValue;

        public string getFilePath(string fileName)
        {
            // Lấy đường dẫn của thư mục chứa mã nguồn của ứng dụng
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Xây dựng đường dẫn tới file
            return Path.Combine(baseDirectory, fileName);
        }

        public string randomPhone(Random random, string prefixPhone, bool validatePhone, int count = 100)
        {
            if (count == 0)
            {
                return "Không tìm thấy số điện thoại hợp lệ sau 100 lần kiểm tra.";
            }

            string phoneNumber = getPhone(random, prefixPhone);

            if (!validatePhone)
            {
                return phoneNumber;
            }
            else
            {
                // Gọi đệ quy nếu số điện thoại đã tồn tại trong danh sách
                if (!checkValidPhone(phoneNumber))
                {
                    return randomPhone(random, prefixPhone, validatePhone, count - 1);
                }
            }

            return phoneNumber;
        }

        private string getPhone(Random random, string prefixPhone)
        {
            string[] array = prefixPhone.Split(';');
            int randomIndex = random.Next(0, array.Length); // Lấy số ngẫu nhiên từ 0 đến (độ dài của mảng - 1)

            string prefix = array[randomIndex];
            string number = random.Next(1000000, 10000000).ToString();

            string phone = prefix + number;
            return phone;
        }

        public bool checkValidPhone(string phone)
        {
            List<string> listPhoneData = new List<string>();

            listPhoneData = (List<string>)cache.Get(keycachePhoneData);

            if (listPhoneData == null || listPhoneData.Count == 0)
            {
                listPhoneData = ReadDataFromFile(getFilePath(listPhoneDataFileName));
                // Lưu kết quả vào cache
                // Kiểm tra nếu kết quả đã được lưu trong cache
                if (cache.Contains(keycachePhoneData))
                {
                    cache.Set(keycachePhoneData, listPhoneData, cacheTime);
                }
                else
                {
                    cache.Add(keycachePhoneData, listPhoneData, cacheTime);
                }
            }
            if (listPhoneData != null && listPhoneData.Count > 0)
            {
                return !listPhoneData.Contains(phone);
            }

            return true;
        }

        public bool checkValidate(string spreadsheetId, string sheetName)
        {
            if (string.IsNullOrEmpty(spreadsheetId))
            {
                MessageBox.Show("Nhập Sheet ID đi đã", "Ẩu thế?");
                return false;
            }
            else if (string.IsNullOrEmpty(sheetName))
            {
                MessageBox.Show("Nhập Sheet Name đi đã", "Ẩu thế?");
                return false;
            }
            return true;
        }

        public bool getDictionaryData(string spreadsheetId, string sheetName, int startRow, string columnLastName, string columnFistName)
        {
            GoogleSheet gs = new GoogleSheet();
            string dataRange = $"{sheetName}!{columnLastName}:{columnFistName}";

            List<string> listLastName = new List<string>();
            List<string> listFirstName = new List<string>();

            // Lấy giá trị từ phạm vi được chỉ định
            var responseData = gs.getData(spreadsheetId, sheetName, dataRange);

            if (responseData != null && responseData.Values.Count > startRow)
            {
                var values = responseData.Values;

                for (int i = startRow; i < values.Count; i++)
                {
                    var item = values[i];
                    if (item != null && item.Count > 0)
                    {
                        if (!string.IsNullOrEmpty(item[0].ToString()))
                        {
                            listLastName.Add(item[0].ToString());
                        }
                        if (item.Count > 1 && !string.IsNullOrEmpty(item[1].ToString()))
                        {
                            listFirstName.Add(item[1].ToString());
                        }
                    }
                }

                // Lưu dữ liệu vào tệp tin
                WriteDataToFile(listFirstName, getFilePath(fistNamePath));
                WriteDataToFile(listLastName, getFilePath(lastNamePath));

                // Lưu kết quả vào cache
                // Kiểm tra nếu kết quả đã được lưu trong cache
                if (cache.Contains(cacheLastKey))
                {
                    cache.Set(cacheLastKey, listLastName, cacheTime);
                }
                else
                {
                    cache.Add(cacheLastKey, listLastName, cacheTime);
                }

                if (cache.Contains(cacheFistKey))
                {
                    cache.Set(cacheFistKey, listFirstName, cacheTime);
                }
                else
                {
                    cache.Add(cacheFistKey, listFirstName, cacheTime);
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        public string getRandomLastName(Random random)
        {
            List<string> listLastName = new List<string>();

            listLastName = (List<string>)cache.Get(cacheLastKey);

            if (listLastName == null || listLastName.Count == 0)
            {
                listLastName = ReadDataFromFile(getFilePath(lastNamePath));
            }
            if (listLastName != null && listLastName.Count > 0)
            {
                var randomIndex = random.Next(0, listLastName.Count);
                return listLastName[randomIndex].ToString();
            }
            else return string.Empty;
        }

        public string getRandomFirstName(Random random)
        {
            List<string> listFirstName = new List<string>();

            listFirstName = (List<string>)cache.Get(cacheFistKey);

            if (listFirstName == null || listFirstName.Count == 0)
            {
                listFirstName = ReadDataFromFile(getFilePath(fistNamePath));
            }
            if (listFirstName != null && listFirstName.Count > 0)
            {
                var randomIndex = random.Next(0, listFirstName.Count);
                return listFirstName[randomIndex].ToString();
            }
            else return string.Empty;
        }

        // Hàm ghi dữ liệu vào file (ghi đè toàn bộ nội dung file cũ)
        public void WriteDataToFile(List<string> data, string filePath)
        {
            string content = string.Join(Environment.NewLine, data);
            File.WriteAllText(filePath, content);
        }

        // Hàm đọc dữ liệu từ tệp tin văn bản và gán vào cache
        public List<string> ReadDataFromFile(string filePath)
        {
            return new List<string>(File.ReadAllLines(filePath));
        }

        public string getRandomBirthDate(Random random)
        {
            DateTime dateOfBirth = GenerateRandomDate(random);
            return dateOfBirth.ToString("ddMMyy");
        }

        DateTime GenerateRandomDate(Random random)
        {
            int year = random.Next(1990, 2001);
            int month = random.Next(1, 13);
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);

            return new DateTime(year, month, day);
        }

        public void focusFirstRow(ListView lv)
        {
            // Đặt focus vào bản ghi đầu tiên
            if (lv.Items.Count > 0)
            {
                lv.Items[0].Selected = true;
                lv.Items[0].Focused = true;
                lv.Focus();
            }
        }

        public void ListViewMouseClick(ListView lv, MouseEventArgs e)
        {
            // Lấy vị trí của cell được click
            ListViewHitTestInfo hitTestInfo = lv.HitTest(e.Location);
            int columnIndex = hitTestInfo.Item.SubItems.IndexOf(hitTestInfo.SubItem);

            if (columnIndex >= 0)
            {
                // Lấy ListViewItem được click
                ListViewItem clickedItem = hitTestInfo.Item;

                // Thay đổi màu sắc của cell được click
                clickedItem.SubItems[columnIndex].BackColor = Color.Aqua;
                clickedItem.SubItems[columnIndex].ForeColor = Color.Aqua;

                var cell = clickedItem.SubItems[columnIndex];
                if (cell != null)
                {
                    cell.ResetStyle();
                    cell.ForeColor = Color.Aqua;
                    cell.BackColor = Color.Aqua;
                    if (!string.IsNullOrEmpty(cell.Text))
                    {
                        // Lấy nội dung của cell được click
                        string cellContent = cell.Text;
                        // Copy nội dung vào Clipboard
                        Clipboard.SetText(cellContent);
                    }
                }
            }
        }
    }
}
