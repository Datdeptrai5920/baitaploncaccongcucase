namespace QuanLyTruongMamNon
{
    partial class frm_ThemGiaoVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grp_TTGV = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lst_GV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_NgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LuongCB = new System.Windows.Forms.TextBox();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.lbl_LuongCB = new System.Windows.Forms.Label();
            this.lbl_HSL = new System.Windows.Forms.Label();
            this.txt_HSL = new System.Windows.Forms.TextBox();
            this.grp_TTCN = new System.Windows.Forms.GroupBox();
            this.bt_ChonAnh = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TenGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TrinhDo = new System.Windows.Forms.ComboBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_TrinhDo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_CMND = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grp_TTGV.SuspendLayout();
            this.grp_TTCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 594);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grp_TTGV);
            this.panel2.Controls.Add(this.grp_TTCN);
            this.panel2.Controls.Add(this.bt_Them);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 594);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // grp_TTGV
            // 
            this.grp_TTGV.BackColor = System.Drawing.Color.Transparent;
            this.grp_TTGV.Controls.Add(this.label8);
            this.grp_TTGV.Controls.Add(this.lst_GV);
            this.grp_TTGV.Controls.Add(this.label2);
            this.grp_TTGV.Controls.Add(this.dtp_NgayVaoLam);
            this.grp_TTGV.Controls.Add(this.label4);
            this.grp_TTGV.Controls.Add(this.txt_LuongCB);
            this.grp_TTGV.Controls.Add(this.txt_MaGV);
            this.grp_TTGV.Controls.Add(this.lbl_LuongCB);
            this.grp_TTGV.Controls.Add(this.lbl_HSL);
            this.grp_TTGV.Controls.Add(this.txt_HSL);
            this.grp_TTGV.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_TTGV.Location = new System.Drawing.Point(114, 313);
            this.grp_TTGV.Name = "grp_TTGV";
            this.grp_TTGV.Size = new System.Drawing.Size(647, 197);
            this.grp_TTGV.TabIndex = 29;
            this.grp_TTGV.TabStop = false;
            this.grp_TTGV.Text = "Thông tin ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(337, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Danh sách giáo viên hiện có :";
            // 
            // lst_GV
            // 
            this.lst_GV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_GV.FullRowSelect = true;
            this.lst_GV.GridLines = true;
            this.lst_GV.Location = new System.Drawing.Point(341, 50);
            this.lst_GV.Name = "lst_GV";
            this.lst_GV.Size = new System.Drawing.Size(284, 122);
            this.lst_GV.TabIndex = 33;
            this.lst_GV.UseCompatibleStateImageBehavior = false;
            this.lst_GV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã giáo viên";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên giáo viên";
            this.columnHeader2.Width = 188;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã giáo viên : ";
            // 
            // dtp_NgayVaoLam
            // 
            this.dtp_NgayVaoLam.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayVaoLam.Location = new System.Drawing.Point(129, 63);
            this.dtp_NgayVaoLam.Name = "dtp_NgayVaoLam";
            this.dtp_NgayVaoLam.Size = new System.Drawing.Size(111, 26);
            this.dtp_NgayVaoLam.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày vào làm :";
            // 
            // txt_LuongCB
            // 
            this.txt_LuongCB.Location = new System.Drawing.Point(129, 146);
            this.txt_LuongCB.Name = "txt_LuongCB";
            this.txt_LuongCB.Size = new System.Drawing.Size(111, 26);
            this.txt_LuongCB.TabIndex = 32;
            this.txt_LuongCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LuongCB_KeyPress);
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Location = new System.Drawing.Point(129, 22);
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(181, 26);
            this.txt_MaGV.TabIndex = 12;
            // 
            // lbl_LuongCB
            // 
            this.lbl_LuongCB.AutoSize = true;
            this.lbl_LuongCB.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LuongCB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_LuongCB.Location = new System.Drawing.Point(22, 146);
            this.lbl_LuongCB.Name = "lbl_LuongCB";
            this.lbl_LuongCB.Size = new System.Drawing.Size(101, 19);
            this.lbl_LuongCB.TabIndex = 31;
            this.lbl_LuongCB.Text = "Lương cơ bản :";
            // 
            // lbl_HSL
            // 
            this.lbl_HSL.AutoSize = true;
            this.lbl_HSL.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HSL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HSL.Location = new System.Drawing.Point(19, 108);
            this.lbl_HSL.Name = "lbl_HSL";
            this.lbl_HSL.Size = new System.Drawing.Size(90, 19);
            this.lbl_HSL.TabIndex = 29;
            this.lbl_HSL.Text = "Hệ số lương :";
            // 
            // txt_HSL
            // 
            this.txt_HSL.Location = new System.Drawing.Point(129, 105);
            this.txt_HSL.Name = "txt_HSL";
            this.txt_HSL.Size = new System.Drawing.Size(111, 26);
            this.txt_HSL.TabIndex = 30;
            this.txt_HSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HSL_KeyPress);
            // 
            // grp_TTCN
            // 
            this.grp_TTCN.BackColor = System.Drawing.Color.Transparent;
            this.grp_TTCN.Controls.Add(this.bt_ChonAnh);
            this.grp_TTCN.Controls.Add(this.imgBox);
            this.grp_TTCN.Controls.Add(this.nu);
            this.grp_TTCN.Controls.Add(this.nam);
            this.grp_TTCN.Controls.Add(this.label7);
            this.grp_TTCN.Controls.Add(this.txt_TenGV);
            this.grp_TTCN.Controls.Add(this.label1);
            this.grp_TTCN.Controls.Add(this.cbb_TrinhDo);
            this.grp_TTCN.Controls.Add(this.txt_SDT);
            this.grp_TTCN.Controls.Add(this.txt_DiaChi);
            this.grp_TTCN.Controls.Add(this.lbl_TrinhDo);
            this.grp_TTCN.Controls.Add(this.label6);
            this.grp_TTCN.Controls.Add(this.lbl_SDT);
            this.grp_TTCN.Controls.Add(this.lbl_CMND);
            this.grp_TTCN.Controls.Add(this.dtp_NgaySinh);
            this.grp_TTCN.Controls.Add(this.label3);
            this.grp_TTCN.Controls.Add(this.txt_CMND);
            this.grp_TTCN.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_TTCN.Location = new System.Drawing.Point(114, 36);
            this.grp_TTCN.Name = "grp_TTCN";
            this.grp_TTCN.Size = new System.Drawing.Size(647, 271);
            this.grp_TTCN.TabIndex = 34;
            this.grp_TTCN.TabStop = false;
            this.grp_TTCN.Text = "Thông tin cá nhân";
            // 
            // bt_ChonAnh
            // 
            this.bt_ChonAnh.Location = new System.Drawing.Point(490, 178);
            this.bt_ChonAnh.Name = "bt_ChonAnh";
            this.bt_ChonAnh.Size = new System.Drawing.Size(135, 25);
            this.bt_ChonAnh.TabIndex = 40;
            this.bt_ChonAnh.Text = "Chọn ảnh...";
            this.bt_ChonAnh.UseVisualStyleBackColor = true;
            this.bt_ChonAnh.Click += new System.EventHandler(this.bt_ChonAnh_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(490, 38);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(135, 141);
            this.imgBox.TabIndex = 39;
            this.imgBox.TabStop = false;
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nu.Location = new System.Drawing.Point(416, 82);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(48, 23);
            this.nu.TabIndex = 31;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nam.Location = new System.Drawing.Point(353, 82);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(57, 23);
            this.nam.TabIndex = 30;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(274, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Giới tính :";
            // 
            // txt_TenGV
            // 
            this.txt_TenGV.Location = new System.Drawing.Point(112, 38);
            this.txt_TenGV.Name = "txt_TenGV";
            this.txt_TenGV.Size = new System.Drawing.Size(353, 26);
            this.txt_TenGV.TabIndex = 1;
            this.txt_TenGV.Click += new System.EventHandler(this.txt_TenGV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên giáo viên : ";
            // 
            // cbb_TrinhDo
            // 
            this.cbb_TrinhDo.FormattingEnabled = true;
            this.cbb_TrinhDo.Location = new System.Drawing.Point(112, 231);
            this.cbb_TrinhDo.Name = "cbb_TrinhDo";
            this.cbb_TrinhDo.Size = new System.Drawing.Size(178, 27);
            this.cbb_TrinhDo.TabIndex = 28;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(353, 190);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(112, 26);
            this.txt_SDT.TabIndex = 26;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(112, 121);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(353, 54);
            this.txt_DiaChi.TabIndex = 19;
            // 
            // lbl_TrinhDo
            // 
            this.lbl_TrinhDo.AutoSize = true;
            this.lbl_TrinhDo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TrinhDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TrinhDo.Location = new System.Drawing.Point(6, 234);
            this.lbl_TrinhDo.Name = "lbl_TrinhDo";
            this.lbl_TrinhDo.Size = new System.Drawing.Size(66, 19);
            this.lbl_TrinhDo.TabIndex = 27;
            this.lbl_TrinhDo.Text = "Trình độ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Địa chỉ :";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_SDT.Location = new System.Drawing.Point(250, 193);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(95, 19);
            this.lbl_SDT.TabIndex = 25;
            this.lbl_SDT.Text = "Số điện thoại :";
            // 
            // lbl_CMND
            // 
            this.lbl_CMND.AutoSize = true;
            this.lbl_CMND.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CMND.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_CMND.Location = new System.Drawing.Point(6, 193);
            this.lbl_CMND.Name = "lbl_CMND";
            this.lbl_CMND.Size = new System.Drawing.Size(85, 19);
            this.lbl_CMND.TabIndex = 23;
            this.lbl_CMND.Text = "Số CMND :";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(112, 79);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(115, 26);
            this.dtp_NgaySinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh : ";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(112, 190);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(115, 26);
            this.txt_CMND.TabIndex = 24;
            this.txt_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress);
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.ForeColor = System.Drawing.Color.MediumBlue;
            this.bt_Them.Location = new System.Drawing.Point(379, 526);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(101, 44);
            this.bt_Them.TabIndex = 33;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // frm_ThemGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 594);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThemGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm giáo viên";
            this.Load += new System.EventHandler(this.frm_ThemGiaoVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grp_TTGV.ResumeLayout(false);
            this.grp_TTGV.PerformLayout();
            this.grp_TTCN.ResumeLayout(false);
            this.grp_TTCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TenGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_NgayVaoLam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label lbl_CMND;
        private System.Windows.Forms.ComboBox cbb_TrinhDo;
        private System.Windows.Forms.Label lbl_TrinhDo;
        private System.Windows.Forms.TextBox txt_LuongCB;
        private System.Windows.Forms.Label lbl_LuongCB;
        private System.Windows.Forms.TextBox txt_HSL;
        private System.Windows.Forms.Label lbl_HSL;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grp_TTGV;
        private System.Windows.Forms.GroupBox grp_TTCN;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lst_GV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button bt_ChonAnh;
        private System.Windows.Forms.PictureBox imgBox;
    }
}