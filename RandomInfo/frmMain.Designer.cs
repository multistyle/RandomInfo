namespace RandomInfo
{
    partial class frmMain
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
            ((System.ComponentModel.ISupportInitialize)(this.numGenData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(852, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(205, 53);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGenData
            // 
            this.btnGenData.Location = new System.Drawing.Point(792, 31);
            this.btnGenData.Name = "btnGenData";
            this.btnGenData.Size = new System.Drawing.Size(265, 75);
            this.btnGenData.TabIndex = 9;
            this.btnGenData.Text = "Sinh dữ liệu";
            this.btnGenData.UseVisualStyleBackColor = true;
            this.btnGenData.Click += new System.EventHandler(this.btnGenData_Click);
            // 
            // numGenData
            // 
            this.numGenData.Location = new System.Drawing.Point(30, 31);
            this.numGenData.Name = "numGenData";
            this.numGenData.Size = new System.Drawing.Size(120, 22);
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
            this.lvData.Location = new System.Drawing.Point(30, 185);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(1040, 337);
            this.lvData.TabIndex = 13;
            this.lvData.UseCompatibleStateImageBehavior = false;
            // 
            // txtPrefixPhone
            // 
            this.txtPrefixPhone.Location = new System.Drawing.Point(187, 31);
            this.txtPrefixPhone.Name = "txtPrefixPhone";
            this.txtPrefixPhone.Size = new System.Drawing.Size(284, 22);
            this.txtPrefixPhone.TabIndex = 14;
            this.txtPrefixPhone.Text = "097;098;096";
            this.txtPrefixPhone.TextChanged += new System.EventHandler(this.txtPrefixPhone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách đầu số";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSheetID
            // 
            this.lbSheetID.AutoSize = true;
            this.lbSheetID.Location = new System.Drawing.Point(27, 64);
            this.lbSheetID.Name = "lbSheetID";
            this.lbSheetID.Size = new System.Drawing.Size(96, 16);
            this.lbSheetID.TabIndex = 17;
            this.lbSheetID.Text = "SpreadsheetId";
            this.lbSheetID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSpreadsheetId
            // 
            this.txtSpreadsheetId.Enabled = false;
            this.txtSpreadsheetId.Location = new System.Drawing.Point(30, 84);
            this.txtSpreadsheetId.Name = "txtSpreadsheetId";
            this.txtSpreadsheetId.Size = new System.Drawing.Size(441, 22);
            this.txtSpreadsheetId.TabIndex = 16;
            this.txtSpreadsheetId.Text = "1U2ZlJicPGnChd40K0OzCKO0k3Rmw5Rb7Dfk7iIT0qxI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "SheetName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSheetName
            // 
            this.txtSheetName.Location = new System.Drawing.Point(490, 84);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(283, 22);
            this.txtSheetName.TabIndex = 18;
            this.txtSheetName.Text = "Data";
            this.txtSheetName.TextChanged += new System.EventHandler(this.txtSheetName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "STT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(179, 140);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(93, 22);
            this.txtSTT.TabIndex = 20;
            this.txtSTT.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Họ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(292, 140);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(93, 22);
            this.txtLastName.TabIndex = 22;
            this.txtLastName.Text = "B";
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(409, 120);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(31, 16);
            this.Tên.TabIndex = 25;
            this.Tên.Text = "Tên";
            this.Tên.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(412, 140);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(93, 22);
            this.txtFirstName.TabIndex = 24;
            this.txtFirstName.Text = "C";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(516, 120);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(34, 16);
            this.lbsdt.TabIndex = 27;
            this.lbsdt.Text = "SĐT";
            this.lbsdt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(519, 140);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(93, 22);
            this.txtPhone.TabIndex = 26;
            this.txtPhone.Text = "D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(635, 140);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(93, 22);
            this.txtID.TabIndex = 28;
            this.txtID.Text = "E";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(740, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ngày tạo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(743, 140);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(93, 22);
            this.txtCreateDate.TabIndex = 30;
            this.txtCreateDate.Text = "F";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Dòng thêm dữ liệu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numStartRow
            // 
            this.numStartRow.Location = new System.Drawing.Point(30, 141);
            this.numStartRow.Name = "numStartRow";
            this.numStartRow.Size = new System.Drawing.Size(111, 22);
            this.numStartRow.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mật khẩu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(489, 31);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(284, 22);
            this.txtPass.TabIndex = 35;
            this.txtPass.Text = "12345678@Abc";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 534);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.numStartRow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.Tên);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSheetName);
            this.Controls.Add(this.lbSheetID);
            this.Controls.Add(this.txtSpreadsheetId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrefixPhone);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.numGenData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenData);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGenData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

