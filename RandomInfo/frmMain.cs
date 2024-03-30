using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Color = System.Drawing.Color;


namespace RandomInfo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenData_Click(object sender, EventArgs e)
        {
            Common cm = new Common();
            Random random = new Random();

            // Xóa tất cả cột
            lvData.Columns.Clear();
            // Xóa tất cả dữ liệu
            lvData.Items.Clear();
            lvData.CheckBoxes = true;
            // Thiết lập kiểu xem của ListView (ví dụ: View.Details để hiển thị các cột)
            lvData.View = View.Details;
            lvData.FullRowSelect = true;
            lvData.GridLines = true;

            // Thêm cột vào ListView
            lvData.Columns.Add("STT").Width = 50;
            lvData.Columns.Add("Số điện thoại").Width = 200;
            lvData.Columns.Add("Họ").Width = 150;
            lvData.Columns.Add("Tên").Width = 150;
            lvData.Columns.Add("ID").Width = 200;
            lvData.Columns.Add("Mật khẩu").Width = 150;

            for (int i = 0; i < numGenData.Value; i++)
            {
                var lastName = cm.getRandomLastName(random);
                var fistName = cm.getRandomFirstName(random);
                var id = lastName + fistName + cm.getRandomBirthDate(random);
                var data = new { Sort = i + 1, LastName = lastName, FirstName = fistName, Phone = cm.randomPhone(random, txtPrefixPhone.Text), ID = id.ToLower(), Pass = txtPass.Text };

                var listItem = new ListViewItem(data.Sort.ToString());
                listItem.SubItems.Add(data.Phone);
                listItem.SubItems.Add(data.LastName);
                listItem.SubItems.Add(data.FirstName);
                listItem.SubItems.Add(data.ID);
                listItem.SubItems.Add(data.Pass);
                listItem.Checked = true;
                listItem.Tag = data;

                lvData.Items.Add(listItem);
            }

            // Đặt focus vào bản ghi đầu tiên
            if (lvData.Items.Count > 0)
            {
                lvData.Items[0].Selected = true;
                lvData.Items[0].Focused = true;
                lvData.Focus();
            }


            lvData.MouseClick += ListViewMouseClick;
        }



        private void ListViewMouseClick(object sender, MouseEventArgs e)
        {

            // Lấy vị trí của cell được click
            ListViewHitTestInfo hitTestInfo = lvData.HitTest(e.Location);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvData.CheckedItems.Count > 0)
                {
                    string fileName = "credentialsAuToData.json";
                    string currentDirectory = Directory.GetCurrentDirectory();
                    string credentialsPath = Path.Combine(currentDirectory, fileName);

                    // Chuỗi phạm vi truy cập (scope)
                    string[] scopes = { SheetsService.Scope.Spreadsheets };

                    // Xác thực và tạo phiên làm việc
                    var credential = GoogleCredential.FromFile(credentialsPath).CreateScoped(scopes);

                    // Tạo dịch vụ Sheets API
                    var service = new SheetsService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = "AutoData"
                    });

                    // ID của bảng tính và tên trang tính cần cập nhật
                    string spreadsheetId = txtSpreadsheetId.Text;
                    string sheetName = txtSheetName.Text;

                    // Chuẩn bị dữ liệu cần cập nhật
                    List<ValueRange> data = new List<ValueRange>();
                    decimal rowIndex = numStartRow.Value;

                    if (numStartRow.Value == 0)
                    {
                        var rangeData = $"{sheetName}!A:Z";

                        // Lấy giá trị từ phạm vi được chỉ định
                        var requestData = service.Spreadsheets.Values.Get(spreadsheetId, rangeData);
                        var responseData = requestData.Execute();
                        if (responseData != null && responseData.Values.Count > 0)
                        {
                            rowIndex = responseData.Values.Count + 1;
                        }
                    }
                    rowIndex = rowIndex == 0 ? 1 : rowIndex;

                    // Các tên cột tương ứng trong Google Sheets
                    string[] columnNames = { txtSTT.Text, txtPhone.Text, txtLastName.Text, txtFirstName.Text, txtID.Text, txtCreateDate.Text };

                    // Xây dựng danh sách data từ các bản ghi được chọn
                    foreach (ListViewItem selectedItem in lvData.CheckedItems)
                    {
                        // Tạo danh sách các giá trị của từng bản ghi
                        List<object> rowValues = new List<object>();

                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            string columnName = columnNames[i];
                            //string range = $"{sheetName}!{columnName}1:{columnName}";
                            string range = $"{sheetName}!{columnName}{rowIndex}:{columnName}{rowIndex}";
                            string value = (rowIndex - 1).ToString();

                            if (i > 0 && i < 5)
                            {
                                value = selectedItem.SubItems[i].Text;
                            }
                            else if (i == 5)
                            {
                                value = DateTime.Now.ToString("dd/MM/yyyy");
                            }

                            data.Add(new ValueRange
                            {
                                Range = range,
                                Values = new List<IList<object>> { new List<object> { value } }
                            });
                        }

                        // Tạo ValueRange cho từng bản ghi
                        ValueRange valueRange = new ValueRange
                        {
                            Range = $"{sheetName}!A{rowIndex}:F{rowIndex}",
                            Values = new List<IList<object>> { rowValues }
                        };

                        data.Add(valueRange);

                        rowIndex++; // Tăng chỉ số hàng
                    }

                    // Cập nhật dữ liệu
                    BatchUpdateValuesRequest request = new BatchUpdateValuesRequest
                    {
                        Data = data,
                        ValueInputOption = "RAW"
                    };

                    SpreadsheetsResource.ValuesResource.BatchUpdateRequest updateRequest =
                        service.Spreadsheets.Values.BatchUpdate(request, spreadsheetId);

                    BatchUpdateValuesResponse response = updateRequest.Execute();

                    AppSetting.UpdateAppSetting(sheetName + "StartRow", rowIndex.ToString());

                    MessageBox.Show("Cập nhật thành công!", "Thành công rồi");

                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được chọn!", "Lỗi cmnr");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            var countGenData = AppSetting.GetAppSettingValue("CountGenData");
            var prefixPhone = AppSetting.GetAppSettingValue("PrefixPhone");
            var passDefault = AppSetting.GetAppSettingValue("PassDefault");
            var sheetName = AppSetting.GetAppSettingValue("SheetName");
            var startRow = AppSetting.GetAppSettingValue(sheetName + "StartRow");

            numGenData.Value = string.IsNullOrEmpty(countGenData) ? 10 : int.Parse(countGenData);
            txtPrefixPhone.Text = !string.IsNullOrEmpty(prefixPhone) ? prefixPhone : "096;097;098";
            txtPass.Text = !string.IsNullOrEmpty(passDefault) ? passDefault : "12345678@Abc";
            txtSheetName.Text = !string.IsNullOrEmpty(sheetName) ? sheetName : "Data";
            numStartRow.Value = string.IsNullOrEmpty(startRow) ? 0 : int.Parse(startRow);


        }

        private void numGenData_ValueChanged(object sender, EventArgs e)
        {
            AppSetting.UpdateAppSetting("CountGenData", numGenData.Value.ToString());

        }

        private void txtPrefixPhone_TextChanged(object sender, EventArgs e)
        {
            AppSetting.UpdateAppSetting("PrefixPhone", txtPrefixPhone.Text);
        }

        private void txtSheetName_TextChanged(object sender, EventArgs e)
        {
            AppSetting.UpdateAppSetting("SheetName", txtSheetName.Text);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            AppSetting.UpdateAppSetting("PassDefault", txtPass.Text);
        }
    }
}