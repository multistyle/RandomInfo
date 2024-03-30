using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Caching;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RandomInfo
{
    public class Common
    {

        // Khởi tạo bộ nhớ cache
        private static MemoryCache cache = MemoryCache.Default;


        public string randomPhone(Random random, string prefixPhone)
        {

            prefixPhone = !string.IsNullOrEmpty(prefixPhone.Trim()) ? prefixPhone : "096;097;098";
            string[] array = prefixPhone.Split(';');
            int randomIndex = random.Next(0, array.Length); // Lấy số ngẫu nhiên từ 0 đến (độ dài của mảng - 1)

            string prefix = array[randomIndex];
            string number = random.Next(1000000, 10000000).ToString();

            string phone = prefix + number;
            if (!checkValidPhone(phone))
            {
                randomPhone(random, prefixPhone);
            }

            return phone;

        }

        //string GenerateRandomPhoneNumber(Random random, string prefixPhone)
        //{


        //    //int randomIndex = new Random().Next(0, array.Length); // Lấy số ngẫu nhiên từ 0 đến (độ dài của mảng - 1)
        //    //int randomElement = array[randomIndex]; // Truy cập vào phần tử có chỉ số ngẫu nhiên

        //    //Console.WriteLine(randomElement);

        //    //string prefix = random.Next(2) == 0 ? "097" : "096";
        //    //string number = random.Next(10000000, 100000000).ToString();

        //    //string phone = prefix + number;
        //    //if (!checkValidPhone(phone))
        //    //{
        //    //    GenerateRandomPhoneNumber(random);
        //    //}

        //    //return phone;
        //}

        public bool checkValidPhone(string phone)
        {


            return true;
        }

        public bool getListPhoneIgnore()
        {


            return true;

        }

        public string getRandomLastName(Random random)
        {

            string[] listLastName =
{
    "Bui",
    "Cao",
    "Chau",
    "Dinh",
    "Doan",
    "Dong",
    "Duong",
    "Ho",
    "Huynh",
    "Lam",
    "Le",
    "Luong",
    "Ly",
    "Ma",
    "Mai",
    "Nguyen",
    "Ngo",
    "Nguyen",
    "Pham",
    "Phan",
    "Phung",
    "Quach",
    "Ta",
    "Thai",
    "Than",
    "Thach",
    "Thieu",
    "Thuy",
    "Tong",
    "Tran",
    "Trinh",
    "Truong",
    "Vo",
    "Vuong",
};

            //List<string> lastNameList = new List<string>(listLastName);
            //// Lưu trữ danh sách vào cache
            //cache.Set("LastNameList", lastNameList, DateTimeOffset.MaxValue);

            //string spreadsheetId = "your-spreadsheet-id";
            //string sheetName = "your-sheet-name";
            //string column = "B";

            //// Khởi tạo dịch vụ Google Sheets
            //var credential = GoogleCredential.FromFile("path-to-your-credentials-file.json")
            //    .CreateScoped(SheetsService.Scope.Spreadsheets);
            //var service = new SheetsService(new BaseClientService.Initializer()
            //{
            //    HttpClientInitializer = credential
            //});

            //// Tạo phạm vi để chỉ định sheet và cột cụ thể
            //string range = $"{sheetName}!{column}:{column}";

            //// Lấy giá trị từ phạm vi đã chỉ định
            //var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            //var response = request.Execute();
            //var values = response.Values;

            //// Kiểm tra và xử lý dữ liệu lấy được
            //if (values != null && values.Count > 0)
            //{
            //    List<string> columnData = new List<string>();
            //    foreach (var row in values)
            //    {
            //        if (row.Count > 0)
            //        {
            //            string cellValue = row[0].ToString();
            //            columnData.Add(cellValue);
            //        }
            //    }

            //    // Sử dụng dữ liệu của cột cụ thể
            //    // ...
            //}
            //// Lấy dữ liệu từ cache
            //var data = cache.Get(key);

            return listLastName[random.Next(listLastName.Length)];


        }

        public string getRandomFirstName(Random random)
        {

            string[] listFirstName = {
    "An",
    "Binh",
    "Cuong",
    "Dat",
    "Hai",
    "Hieu",
    "Hoang",
    "Hung",
    "Hung",
    "Khanh",
    "Kien",
    "Lam",
    "Long",
    "Minh",
    "Nam",
    "Nghia",
    "Ngoc",
    "Phong",
    "Phuc",
    "Quan",
    "Quang",
    "Sang",
    "Son",
    "Tuan",
    "Tung",
    "Tu",
    "Van",
    "Vinh",
    "Vu",
    "Xuan",
    "Yen",
    "Anh",
    "Bao",
    "Bien",
    "Buu",
    "Canh",
    "Chau",
    "Chi",
    "Chinh",
    "Chuong",
    "Dai",
    "Danh",
    "Dinh",
    "Do",
    "Du",
    "Duc",
    "Dung",
    "Gia",
    "Giang",
    "Giao",
    "Ha",
    "Hanh",
    "Hiep",
    "Hoa",
    "Hoi",
    "Hong",
    "Huong",
    "Huy",
    "Khai",
    "Khan",
    "Khoa",
    "Khoi",
    "Khuong",
    "Kiet",
    "Lan",
    "Lien",
    "Lieu",
    "Linh",
    "Loc",
    "Luan",
    "Luc",
    "Luu",
    "Manh",
    "Mau",
    "Minh",
    "My",
    "Nhan",
    "Nhat",
    "Ninh",
    "Nhuan",
    "Phat",
    "Phu",
    "Phuc",
    "Phung",
    "Quoc",
    "Quy",
    "Quyen",
    "Quyet",
    "Quynh",
    "Sau",
    "Sinh",
    "Sung",
    "Tai",
    "Tam",
    "Tan",
    "Tham",
    "Thang",
    "Thao",
    "Thau",
    "Thinh",
    "Tho",
    "Thong",
    "Thuan",
    "Thuy",
    "Thy",
    "Tien",
    "Tinh",
    "Toan",
    "Tong",
    "Tran",
    "Tri",
    "Trinh",
    "Trong",
    "Trung",
    "Tuyen",
    "Ty",
    "Uy",
    "Vang",
    "Vinh",
    "Vui",
    "Vu",
    "Xuan",
    "Y",
    "Anh",
    "Bach",
    "Bao",
    "Bich",
    "Binh",
    "Cam",
    "Can",
    "Chau",
    "Chi",
    "Diep",
    "Diem",
    "Dung",
    "Giang",
    "Giao",
    "Ha",
    "Han",
    "Hanh",
    "Hoa",
    "Huong",
    "Khanh",
    "Kieu",
    "Kim",
    "Lam",
    "Lan",
    "Lien",
    "Lieu",
    "Linh",
    "Loan",
    "Luyen",
    "Ly",
    "Mai",
    "Minh",
    "My",
    "Ngan",
    "Ngoc",
    "Nhan",
    "Nhi",
    "Nhung",
    "Oanh",
    "Phuong",
    "Quynh",
    "Suong",
    "Tham",
    "Thao",
    "Thien",
    "Thu",
    "Thuy",
    "Tien",
    "Tram",
    "Trang",
    "Trinh",
    "Truc",
    "Tuyet",
    "Uyen",
    "Van",
    "Vi",
    "Vinh",
    "Xuan",
    "Yen"
            // Thêm tên tiếng Việt không dấu khác nếu cần
        };

            return listFirstName[random.Next(listFirstName.Length)];
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
