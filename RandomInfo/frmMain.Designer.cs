namespace RandomInfo
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGenData = new System.Windows.Forms.Button();
            this.numGenData = new System.Windows.Forms.NumericUpDown();
            this.lvData = new System.Windows.Forms.ListView();
            this.txtPrefixPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSheetID = new System.Windows.Forms.Label();
            this.txtSpreadsheetId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbsdt = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numStartRow = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.tbLoadData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvDataFromExcel = new System.Windows.Forms.ListView();
            this.btnLoadDataFromExcel = new System.Windows.Forms.Button();
            this.txtLoadSheetID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLoadSheetName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numTo = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGenData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).BeginInit();
            this.tbLoadData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(627, 90);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 41);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGenData
            // 
            this.btnGenData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenData.Location = new System.Drawing.Point(627, 21);
            this.btnGenData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenData.Name = "btnGenData";
            this.btnGenData.Size = new System.Drawing.Size(164, 63);
            this.btnGenData.TabIndex = 9;
            this.btnGenData.Text = "Sinh dữ liệu";
            this.btnGenData.UseVisualStyleBackColor = true;
            this.btnGenData.Click += new System.EventHandler(this.btnGenData_Click);
            // 
            // numGenData
            // 
            this.numGenData.Location = new System.Drawing.Point(16, 21);
            this.numGenData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numGenData.Name = "numGenData";
            this.numGenData.Size = new System.Drawing.Size(105, 20);
            this.numGenData.TabIndex = 12;
            this.numGenData.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGenData.ValueChanged += new System.EventHandler(this.numGenData_ValueChanged);
            // 
            // lvData
            // 
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(5, 135);
            this.lvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(781, 292);
            this.lvData.TabIndex = 13;
            this.lvData.UseCompatibleStateImageBehavior = false;
            // 
            // txtPrefixPhone
            // 
            this.txtPrefixPhone.Location = new System.Drawing.Point(149, 21);
            this.txtPrefixPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrefixPhone.Name = "txtPrefixPhone";
            this.txtPrefixPhone.Size = new System.Drawing.Size(214, 20);
            this.txtPrefixPhone.TabIndex = 14;
            this.txtPrefixPhone.Text = "097;098;096";
            this.txtPrefixPhone.TextChanged += new System.EventHandler(this.txtPrefixPhone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách đầu số";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSheetID
            // 
            this.lbSheetID.AutoSize = true;
            this.lbSheetID.Location = new System.Drawing.Point(13, 49);
            this.lbSheetID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSheetID.Name = "lbSheetID";
            this.lbSheetID.Size = new System.Drawing.Size(49, 13);
            this.lbSheetID.TabIndex = 17;
            this.lbSheetID.Text = "Sheet ID";
            this.lbSheetID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSpreadsheetId
            // 
            this.txtSpreadsheetId.Enabled = false;
            this.txtSpreadsheetId.Location = new System.Drawing.Point(16, 64);
            this.txtSpreadsheetId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSpreadsheetId.Name = "txtSpreadsheetId";
            this.txtSpreadsheetId.Size = new System.Drawing.Size(347, 20);
            this.txtSpreadsheetId.TabIndex = 16;
            this.txtSpreadsheetId.Text = "1U2ZlJicPGnChd40K0OzCKO0k3Rmw5Rb7Dfk7iIT0qxI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "SheetName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSheetName
            // 
            this.txtSheetName.Location = new System.Drawing.Point(377, 64);
            this.txtSheetName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(213, 20);
            this.txtSheetName.TabIndex = 18;
            this.txtSheetName.Text = "Data";
            this.txtSheetName.TextChanged += new System.EventHandler(this.txtSheetName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "STT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(127, 106);
            this.txtSTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(71, 20);
            this.txtSTT.TabIndex = 20;
            this.txtSTT.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Họ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(212, 106);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(71, 20);
            this.txtLastName.TabIndex = 22;
            this.txtLastName.Text = "B";
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(300, 90);
            this.Tên.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(26, 13);
            this.Tên.TabIndex = 25;
            this.Tên.Text = "Tên";
            this.Tên.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(302, 106);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(71, 20);
            this.txtFirstName.TabIndex = 24;
            this.txtFirstName.Text = "C";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(380, 90);
            this.lbsdt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(29, 13);
            this.lbsdt.TabIndex = 27;
            this.lbsdt.Text = "SĐT";
            this.lbsdt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(382, 106);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(71, 20);
            this.txtPhone.TabIndex = 26;
            this.txtPhone.Text = "D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(469, 106);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(71, 20);
            this.txtID.TabIndex = 28;
            this.txtID.Text = "E";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ngày tạo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(550, 106);
            this.txtCreateDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(71, 20);
            this.txtCreateDate.TabIndex = 30;
            this.txtCreateDate.Text = "F";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Dòng thêm dữ liệu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numStartRow
            // 
            this.numStartRow.Location = new System.Drawing.Point(15, 107);
            this.numStartRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numStartRow.Name = "numStartRow";
            this.numStartRow.Size = new System.Drawing.Size(83, 20);
            this.numStartRow.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mật khẩu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(376, 21);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(214, 20);
            this.txtPass.TabIndex = 35;
            this.txtPass.Text = "12345678@Abc";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // tbLoadData
            // 
            this.tbLoadData.Controls.Add(this.tabPage1);
            this.tbLoadData.Controls.Add(this.tabPage2);
            this.tbLoadData.Location = new System.Drawing.Point(3, 12);
            this.tbLoadData.Name = "tbLoadData";
            this.tbLoadData.SelectedIndex = 0;
            this.tbLoadData.Size = new System.Drawing.Size(809, 458);
            this.tbLoadData.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvData);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.txtPass);
            this.tabPage1.Controls.Add(this.btnGenData);
            this.tabPage1.Controls.Add(this.numStartRow);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.numGenData);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtPrefixPhone);
            this.tabPage1.Controls.Add(this.txtCreateDate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtSpreadsheetId);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.lbSheetID);
            this.tabPage1.Controls.Add(this.lbsdt);
            this.tabPage1.Controls.Add(this.txtSheetName);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Tên);
            this.tabPage1.Controls.Add(this.txtSTT);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinh dữ liệu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.numTo);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.numFrom);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnLoadDataFromExcel);
            this.tabPage2.Controls.Add(this.txtLoadSheetID);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtLoadSheetName);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.lvDataFromExcel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lấy dữ liệu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvDataFromExcel
            // 
            this.lvDataFromExcel.HideSelection = false;
            this.lvDataFromExcel.Location = new System.Drawing.Point(7, 127);
            this.lvDataFromExcel.Name = "lvDataFromExcel";
            this.lvDataFromExcel.Size = new System.Drawing.Size(791, 299);
            this.lvDataFromExcel.TabIndex = 0;
            this.lvDataFromExcel.UseCompatibleStateImageBehavior = false;
            // 
            // btnLoadDataFromExcel
            // 
            this.btnLoadDataFromExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDataFromExcel.Location = new System.Drawing.Point(582, 15);
            this.btnLoadDataFromExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadDataFromExcel.Name = "btnLoadDataFromExcel";
            this.btnLoadDataFromExcel.Size = new System.Drawing.Size(209, 63);
            this.btnLoadDataFromExcel.TabIndex = 20;
            this.btnLoadDataFromExcel.Text = "Lấy dữ liệu";
            this.btnLoadDataFromExcel.UseVisualStyleBackColor = true;
            this.btnLoadDataFromExcel.Click += new System.EventHandler(this.btnLoadDataFromExcel_Click);
            // 
            // txtLoadSheetID
            // 
            this.txtLoadSheetID.Enabled = false;
            this.txtLoadSheetID.Location = new System.Drawing.Point(21, 22);
            this.txtLoadSheetID.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoadSheetID.Name = "txtLoadSheetID";
            this.txtLoadSheetID.Size = new System.Drawing.Size(292, 20);
            this.txtLoadSheetID.TabIndex = 21;
            this.txtLoadSheetID.Text = "1U2ZlJicPGnChd40K0OzCKO0k3Rmw5Rb7Dfk7iIT0qxI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sheet ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLoadSheetName
            // 
            this.txtLoadSheetName.Location = new System.Drawing.Point(340, 22);
            this.txtLoadSheetName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoadSheetName.Name = "txtLoadSheetName";
            this.txtLoadSheetName.Size = new System.Drawing.Size(213, 20);
            this.txtLoadSheetName.TabIndex = 23;
            this.txtLoadSheetName.Text = "Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "SheetName";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numFrom
            // 
            this.numFrom.Location = new System.Drawing.Point(22, 61);
            this.numFrom.Margin = new System.Windows.Forms.Padding(2);
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(83, 20);
            this.numFrom.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 44);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Bắt đầu lấy từ dòng?";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numTo
            // 
            this.numTo.Location = new System.Drawing.Point(146, 61);
            this.numTo.Margin = new System.Windows.Forms.Padding(2);
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(83, 20);
            this.numTo.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(143, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Lấy đến dòng?";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Orange;
            this.label14.Location = new System.Drawing.Point(252, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Lấy hết thì để cả hai thông tin là 0";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 472);
            this.Controls.Add(this.tbLoadData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGenData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).EndInit();
            this.tbLoadData.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGenData;
        private System.Windows.Forms.NumericUpDown numGenData;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.TextBox txtPrefixPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSheetID;
        private System.Windows.Forms.TextBox txtSpreadsheetId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numStartRow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TabControl tbLoadData;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLoadDataFromExcel;
        private System.Windows.Forms.TextBox txtLoadSheetID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLoadSheetName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvDataFromExcel;
        private System.Windows.Forms.NumericUpDown numTo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}

