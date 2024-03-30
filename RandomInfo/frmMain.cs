using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static Google.Apis.Requests.BatchRequest;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Color = System.Drawing.Color;


namespace RandomInfo
{
    public partial class Main : Form
    {
        AppSetting setting = new AppSetting();

        public Main()
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
            lvData.Columns.Add("Số điện thoại").Width = 150;
            lvData.Columns.Add("Họ").Width = 100;
            lvData.Columns.Add("Tên").Width = 100;
            lvData.Columns.Add("ID").Width = 180;
            lvData.Columns.Add("Mật khẩu").Width = 120;

            for (int i = 0; i < numGenData.Value; i++)
            {
                var lastName = cm.getRandomLastName(random);
                var fistName = cm.getRandomFirstName(random);
                var id = lastName + fistName + cm.getRandomBirthDate(random);
                string phoneNumber = cm.randomPhone(random, txtPrefixPhone.Text, chkValidatePhone.Checked);

                var data = new { Sort = i + 1, LastName = lastName, FirstName = fistName, Phone = phoneNumber, ID = id.ToLower(), Pass = txtPass.Text };

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
            cm.focusFirstRow(lvData);

            lvData.MouseClick += ListViewMouseClick;
        }

        private void ListViewMouseClick(object sender, MouseEventArgs e)
        {
            Common cm = new Common();
            cm.ListViewMouseClick(lvData, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvData.CheckedItems.Count > 0)
                {
                    // ID của bảng tính và tên trang tính cần cập nhật
                    string spreadsheetId = txtSpreadsheetId.Text;
                    string sheetName = txtSheetName.Text;
                    GoogleSheet gs = new GoogleSheet();
                    // Chuẩn bị dữ liệu cần cập nhật
                    List<ValueRange> data = new List<ValueRange>();
                    decimal rowIndex = numStartRow.Value;

                    if (numStartRow.Value == 0)
                    {
                        var rangeData = $"{sheetName}!A:Z";
                        // Lấy giá trị từ phạm vi được chỉ định
                        var responseData = gs.getData(spreadsheetId, sheetName, rangeData);
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

                    BatchUpdateValuesResponse response = gs.UpdateData(spreadsheetId, data);

                    setting.UpdateAppSetting(sheetName + "StartRow", rowIndex.ToString());

                    MessageBox.Show("Vừa đẩy lên " + response.TotalUpdatedRows.ToString() + " bản ghi! Vào sheet: " + sheetName, "Thành công rồi");
                    // Xóa tất cả cột
                    lvDataFromExcel.Columns.Clear();
                    // Xóa tất cả dữ liệu
                    lvDataFromExcel.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được chọn!", "Lỗi cmnr");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi cmnr");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var countGenData = setting.GetAppSettingValue("CountGenData");
            var prefixPhone = setting.GetAppSettingValue("PrefixPhone");
            var passDefault = setting.GetAppSettingValue("PassDefault");
            var sheetName = setting.GetAppSettingValue("SheetName");
            var startRow = setting.GetAppSettingValue(sheetName + "StartRow");
            var lastSyncDictionary = setting.GetAppSettingValue("LastSyncDictionary");
            var checkSyncData = setting.GetAppSettingValue("CheckSyncData");
            var checkValidatePhone = setting.GetAppSettingValue("CheckValidatePhone");

            numGenData.Value = string.IsNullOrEmpty(countGenData) ? 10 : int.Parse(countGenData);
            txtPrefixPhone.Text = !string.IsNullOrEmpty(prefixPhone) ? prefixPhone : "096;097;098";
            txtPass.Text = !string.IsNullOrEmpty(passDefault) ? passDefault : "12345678@Abc";
            txtSheetName.Text = !string.IsNullOrEmpty(sheetName) ? sheetName : "Data";
            numStartRow.Value = string.IsNullOrEmpty(startRow) ? 0 : int.Parse(startRow);
            lbTimeUpdate.Text = string.IsNullOrEmpty(lastSyncDictionary) ? "Danh sách mặc định" : lastSyncDictionary;
            chkSyncData.Checked = string.IsNullOrEmpty(checkSyncData) ? false : bool.Parse(checkSyncData);
            chkValidatePhone.Checked = string.IsNullOrEmpty(checkValidatePhone) ? false : bool.Parse(checkValidatePhone);

            txtFilePhoneNumber.Text = new Common().getFilePath("ListPhoneData.txt");
        }

        private void numGenData_ValueChanged(object sender, EventArgs e)
        {
            setting.UpdateAppSetting("CountGenData", numGenData.Value.ToString());

        }

        private void txtPrefixPhone_TextChanged(object sender, EventArgs e)
        {
            setting.UpdateAppSetting("PrefixPhone", txtPrefixPhone.Text);
        }

        private void txtSheetName_TextChanged(object sender, EventArgs e)
        {
            setting.UpdateAppSetting("SheetName", txtSheetName.Text);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            setting.UpdateAppSetting("PassDefault", txtPass.Text);
        }

        private void btnLoadDataFromExcel_Click(object sender, EventArgs e)
        {
            // ID của bảng tính và tên trang tính cần cập nhật
            string spreadsheetId = txtLoadSheetID.Text;
            string sheetName = txtLoadSheetName.Text;
            var rangeData = $"{sheetName}!A{numFrom.Value}:Z";
            string columnFilterName = "F";
            string filterValue = txtDate.Text;

            // Xử lý kết quả
            // ...
            if (numTo.Value > 0 && numTo.Value > numFrom.Value)
            {
                rangeData = $"{sheetName}!A{numFrom.Value}:Z{numTo.Value}";
            }

            //if (!string.IsNullOrEmpty(filterValue))
            //{
            //    // Áp dụng điều kiện lọc
            //    string filterCondition = $"'{columnFilterName}=\"{filterValue}\"'";
            //    rangeData += $"&{filterCondition}";
            //}

            GoogleSheet gs = new GoogleSheet();
            Common cm = new Common();

            if (cm.checkValidate(spreadsheetId, sheetName))
            {
                // Xóa tất cả cột
                lvDataFromExcel.Columns.Clear();
                // Xóa tất cả dữ liệu
                lvDataFromExcel.Items.Clear();
                //lvDataFromExcel.CheckBoxes = true;
                // Thiết lập kiểu xem của ListView (ví dụ: View.Details để hiển thị các cột)
                lvDataFromExcel.View = View.Details;
                lvDataFromExcel.FullRowSelect = true;
                lvDataFromExcel.GridLines = true;

                // Lấy giá trị từ phạm vi được chỉ định
                var responseData = gs.getData(spreadsheetId, sheetName, rangeData);

                if (responseData != null && responseData.Values.Count > 0)
                {
                    var values = responseData.Values;
                    var listViewItems = new List<ListViewItem>();
                    int count = 0;
                    // Thêm cột vào ListView
                    lvDataFromExcel.Columns.Add("STT").Width = 50;
                    lvDataFromExcel.Columns.Add("Họ").Width = 100;
                    lvDataFromExcel.Columns.Add("Tên").Width = 100;
                    lvDataFromExcel.Columns.Add("Số điện thoại").Width = 150;
                    lvDataFromExcel.Columns.Add("ID").Width = 180;
                    lvDataFromExcel.Columns.Add("Ngày tạo").Width = 120;


                    //// Lấy tên cột từ dòng đầu tiên
                    //var headerRow = values[0];

                    //for (int i = (int)numStartRow.Value; i < headerRow.Count; i++)
                    //{
                    //    lvDataFromExcel.Columns.Add(headerRow[i].ToString());
                    //}

                    // Lấy dữ liệu từ các dòng sau
                    for (int i = 0; i < values.Count; i++)
                    {
                        var dataRow = values[i];

                        if (!string.IsNullOrEmpty(filterValue))
                        {
                            if (!(dataRow[(int)numCreatedDate.Value].ToString() == filterValue))
                            {
                                continue;
                            }
                        }

                        var listViewItem = new ListViewItem();
                        listViewItem.Text = (i + 1).ToString();

                        for (int j = 1; j < dataRow.Count; j++)
                        {
                            listViewItem.SubItems.Add(dataRow[j].ToString());
                        }

                        //listViewItem.Checked = true;
                        count++;
                        listViewItems.Add(listViewItem);
                    }

                    lvDataFromExcel.Items.AddRange(listViewItems.ToArray());

                    //lvDataFromExcel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                    // Đặt focus vào bản ghi đầu tiên
                    cm.focusFirstRow(lvDataFromExcel);

                    lvDataFromExcel.MouseClick += ListViewLoadMouseClick;

                    MessageBox.Show("Lấy được " + count.ToString() + " bản ghi", "Ngon rồi!");
                }
            }
        }

        private void ListViewLoadMouseClick(object sender, MouseEventArgs e)
        {
            Common cm = new Common();
            cm.ListViewMouseClick(lvDataFromExcel, e);
        }

        private void btnGetDictionary_Click(object sender, EventArgs e)
        {
            Common cm = new Common();
            // ID của bảng tính và tên trang tính cần cập nhật
            string spreadsheetId = txtLoadSheetID.Text;
            string sheetName = txtDicSheet.Text;
            bool result = false;
            try
            {
                if (cm.checkValidate(spreadsheetId, sheetName))
                {
                    result = cm.getDictionaryData(spreadsheetId, sheetName, (int)numDicStartRow.Value, txtDicLastName.Text, txtDicFirstName.Text);
                    if (result)
                    {
                        DateTime now = DateTime.Now;
                        string formattedDateTime = "Cập nhật lúc: " + now.ToString("HH:mm:ss dd/MM/yyyy");
                        lbTimeUpdate.Text = formattedDateTime;

                        setting.UpdateAppSetting("LastSyncDictionary", formattedDateTime);

                        MessageBox.Show("Cập nhật danh sách Họ và Tên ok!", "Ngon rồi!");
                    }
                    else
                    {
                        MessageBox.Show("Không cập nhật được rồi!", "Dở rồi!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi cmnr");
            }
        }

        private void chkValidatePhone_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateAppSetting("CheckValidatePhone", chkValidatePhone.Checked.ToString());
        }

        private void chkSyncData_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateAppSetting("CheckSyncData", chkSyncData.Checked.ToString());
        }

        private void btnUpdatePhoneValidate_Click(object sender, EventArgs e)
        {
            var cm = new Common();
            cm.cache.Remove("ListPhoneData");
        }
    }
}