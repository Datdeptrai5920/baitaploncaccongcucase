namespace QuanLyTruongMamNon
{
    partial class frm_ThongTinGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongTinGiaoVien));
            this.tab_GiaoVien = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ts_ChucNang = new System.Windows.Forms.ToolStrip();
            this.tSb_Them = new System.Windows.Forms.ToolStripButton();
            this.tSb_Xoa = new System.Windows.Forms.ToolStripButton();
            this.tSb_Sua = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_TTHS = new System.Windows.Forms.GroupBox();
            this.txt_Lương = new System.Windows.Forms.TextBox();
            this.lbl_Luong = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.txt_LopHienTai = new System.Windows.Forms.TextBox();
            this.lbl_TenLop = new System.Windows.Forms.Label();
            this.cbb_TrinhDo = new System.Windows.Forms.ComboBox();
            this.lbl_TrinhDo = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.lbl_CMND = new System.Windows.Forms.Label();
            this.dtp_NgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.txt_NgayThangNam = new System.Windows.Forms.DateTimePicker();
            this.txt_LuongCB = new System.Windows.Forms.TextBox();
            this.lbl_LuongCB = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.lbl_MaGV = new System.Windows.Forms.Label();
            this.lbl_NgayVaoLam = new System.Windows.Forms.Label();
            this.txt_HSL = new System.Windows.Forms.TextBox();
            this.lbl_HSL = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TenGV = new System.Windows.Forms.Label();
            this.grp_DSLH = new System.Windows.Forms.GroupBox();
            this.TreeView_DSGV = new System.Windows.Forms.TreeView();
            this.tab_GiaoVien.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ts_ChucNang.SuspendLayout();
            this.grp_TTHS.SuspendLayout();
            this.grp_DSLH.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_GiaoVien
            // 
            this.tab_GiaoVien.Controls.Add(this.tabPage1);
            this.tab_GiaoVien.ItemSize = new System.Drawing.Size(300, 24);
            this.tab_GiaoVien.Location = new System.Drawing.Point(-6, 0);
            this.tab_GiaoVien.Name = "tab_GiaoVien";
            this.tab_GiaoVien.SelectedIndex = 0;
            this.tab_GiaoVien.Size = new System.Drawing.Size(898, 563);
            this.tab_GiaoVien.TabIndex = 0;
            this.tab_GiaoVien.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tab_GiaoVien_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.grp_TTHS);
            this.tabPage1.Controls.Add(this.grp_DSLH);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin giáo viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ts_ChucNang);
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 403);
            this.panel2.TabIndex = 12;
            // 
            // ts_ChucNang
            // 
            this.ts_ChucNang.AutoSize = false;
            this.ts_ChucNang.BackColor = System.Drawing.Color.Honeydew;
            this.ts_ChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_ChucNang.GripMargin = new System.Windows.Forms.Padding(4);
            this.ts_ChucNang.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.ts_ChucNang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ts_ChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSb_Them,
            this.tSb_Xoa,
            this.tSb_Sua});
            this.ts_ChucNang.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ts_ChucNang.Location = new System.Drawing.Point(0, 0);
            this.ts_ChucNang.Name = "ts_ChucNang";
            this.ts_ChucNang.Size = new System.Drawing.Size(110, 403);
            this.ts_ChucNang.TabIndex = 13;
            this.ts_ChucNang.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ts_ChucNang_ItemClicked);
            // 
            // tSb_Them
            // 
            this.tSb_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSb_Them.Image = ((System.Drawing.Image)(resources.GetObject("tSb_Them.Image")));
            this.tSb_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSb_Them.Name = "tSb_Them";
            this.tSb_Them.Size = new System.Drawing.Size(108, 123);
            this.tSb_Them.Text = "Thêm";
            this.tSb_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSb_Them.Click += new System.EventHandler(this.tSb_Them_Click);
            // 
            // tSb_Xoa
            // 
            this.tSb_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSb_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("tSb_Xoa.Image")));
            this.tSb_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSb_Xoa.Name = "tSb_Xoa";
            this.tSb_Xoa.Size = new System.Drawing.Size(108, 123);
            this.tSb_Xoa.Text = "Xóa";
            this.tSb_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tSb_Sua
            // 
            this.tSb_Sua.BackColor = System.Drawing.SystemColors.Control;
            this.tSb_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSb_Sua.Image = ((System.Drawing.Image)(resources.GetObject("tSb_Sua.Image")));
            this.tSb_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSb_Sua.Name = "tSb_Sua";
            this.tSb_Sua.Size = new System.Drawing.Size(108, 123);
            this.tSb_Sua.Text = "Sửa";
            this.tSb_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 100);
            this.panel1.TabIndex = 11;
            // 
            // grp_TTHS
            // 
            this.grp_TTHS.Controls.Add(this.txt_Lương);
            this.grp_TTHS.Controls.Add(this.lbl_Luong);
            this.grp_TTHS.Controls.Add(this.txt_MaLop);
            this.grp_TTHS.Controls.Add(this.lbl_MaLop);
            this.grp_TTHS.Controls.Add(this.txt_LopHienTai);
            this.grp_TTHS.Controls.Add(this.lbl_TenLop);
            this.grp_TTHS.Controls.Add(this.cbb_TrinhDo);
            this.grp_TTHS.Controls.Add(this.lbl_TrinhDo);
            this.grp_TTHS.Controls.Add(this.txt_SDT);
            this.grp_TTHS.Controls.Add(this.lbl_SDT);
            this.grp_TTHS.Controls.Add(this.txt_CMND);
            this.grp_TTHS.Controls.Add(this.lbl_CMND);
            this.grp_TTHS.Controls.Add(this.dtp_NgayVaoLam);
            this.grp_TTHS.Controls.Add(this.txt_NgayThangNam);
            this.grp_TTHS.Controls.Add(this.txt_LuongCB);
            this.grp_TTHS.Controls.Add(this.lbl_LuongCB);
            this.grp_TTHS.Controls.Add(this.txt_Ma);
            this.grp_TTHS.Controls.Add(this.lbl_MaGV);
            this.grp_TTHS.Controls.Add(this.lbl_NgayVaoLam);
            this.grp_TTHS.Controls.Add(this.txt_HSL);
            this.grp_TTHS.Controls.Add(this.lbl_HSL);
            this.grp_TTHS.Controls.Add(this.txt_DiaChi);
            this.grp_TTHS.Controls.Add(this.label4);
            this.grp_TTHS.Controls.Add(this.rdb_Nu);
            this.grp_TTHS.Controls.Add(this.rdb_Nam);
            this.grp_TTHS.Controls.Add(this.label3);
            this.grp_TTHS.Controls.Add(this.txt_HoTen);
            this.grp_TTHS.Controls.Add(this.label2);
            this.grp_TTHS.Controls.Add(this.lbl_TenGV);
            this.grp_TTHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TTHS.ForeColor = System.Drawing.Color.Blue;
            this.grp_TTHS.Location = new System.Drawing.Point(390, 106);
            this.grp_TTHS.Name = "grp_TTHS";
            this.grp_TTHS.Size = new System.Drawing.Size(483, 403);
            this.grp_TTHS.TabIndex = 10;
            this.grp_TTHS.TabStop = false;
            this.grp_TTHS.Text = "Thông tin giáo viên";
            // 
            // txt_Lương
            // 
            this.txt_Lương.Enabled = false;
            this.txt_Lương.Location = new System.Drawing.Point(136, 318);
            this.txt_Lương.Name = "txt_Lương";
            this.txt_Lương.Size = new System.Drawing.Size(111, 26);
            this.txt_Lương.TabIndex = 30;
            // 
            // lbl_Luong
            // 
            this.lbl_Luong.AutoSize = true;
            this.lbl_Luong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Luong.Location = new System.Drawing.Point(23, 321);
            this.lbl_Luong.Name = "lbl_Luong";
            this.lbl_Luong.Size = new System.Drawing.Size(56, 19);
            this.lbl_Luong.TabIndex = 29;
            this.lbl_Luong.Text = "Lương :";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Enabled = false;
            this.txt_MaLop.Location = new System.Drawing.Point(353, 243);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(111, 26);
            this.txt_MaLop.TabIndex = 28;
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MaLop.Location = new System.Drawing.Point(287, 246);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(60, 19);
            this.lbl_MaLop.TabIndex = 27;
            this.lbl_MaLop.Text = "Mã lớp :";
            // 
            // txt_LopHienTai
            // 
            this.txt_LopHienTai.Enabled = false;
            this.txt_LopHienTai.Location = new System.Drawing.Point(136, 243);
            this.txt_LopHienTai.Name = "txt_LopHienTai";
            this.txt_LopHienTai.Size = new System.Drawing.Size(112, 26);
            this.txt_LopHienTai.TabIndex = 26;
            // 
            // lbl_TenLop
            // 
            this.lbl_TenLop.AutoSize = true;
            this.lbl_TenLop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TenLop.Location = new System.Drawing.Point(24, 246);
            this.lbl_TenLop.Name = "lbl_TenLop";
            this.lbl_TenLop.Size = new System.Drawing.Size(105, 19);
            this.lbl_TenLop.TabIndex = 25;
            this.lbl_TenLop.Text = "Lớp chủ nhiệm :";
            // 
            // cbb_TrinhDo
            // 
            this.cbb_TrinhDo.FormattingEnabled = true;
            this.cbb_TrinhDo.Location = new System.Drawing.Point(136, 210);
            this.cbb_TrinhDo.Name = "cbb_TrinhDo";
            this.cbb_TrinhDo.Size = new System.Drawing.Size(143, 27);
            this.cbb_TrinhDo.TabIndex = 24;
            // 
            // lbl_TrinhDo
            // 
            this.lbl_TrinhDo.AutoSize = true;
            this.lbl_TrinhDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TrinhDo.Location = new System.Drawing.Point(24, 213);
            this.lbl_TrinhDo.Name = "lbl_TrinhDo";
            this.lbl_TrinhDo.Size = new System.Drawing.Size(66, 19);
            this.lbl_TrinhDo.TabIndex = 23;
            this.lbl_TrinhDo.Text = "Trình độ :";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Enabled = false;
            this.txt_SDT.Location = new System.Drawing.Point(354, 178);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(112, 26);
            this.txt_SDT.TabIndex = 22;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_SDT.Location = new System.Drawing.Point(254, 181);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(95, 19);
            this.lbl_SDT.TabIndex = 21;
            this.lbl_SDT.Text = "Số điện thoại :";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Enabled = false;
            this.txt_CMND.Location = new System.Drawing.Point(136, 178);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(112, 26);
            this.txt_CMND.TabIndex = 20;
            // 
            // lbl_CMND
            // 
            this.lbl_CMND.AutoSize = true;
            this.lbl_CMND.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_CMND.Location = new System.Drawing.Point(23, 181);
            this.lbl_CMND.Name = "lbl_CMND";
            this.lbl_CMND.Size = new System.Drawing.Size(85, 19);
            this.lbl_CMND.TabIndex = 19;
            this.lbl_CMND.Text = "Số CMND :";
            // 
            // dtp_NgayVaoLam
            // 
            this.dtp_NgayVaoLam.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayVaoLam.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayVaoLam.Location = new System.Drawing.Point(353, 87);
            this.dtp_NgayVaoLam.Name = "dtp_NgayVaoLam";
            this.dtp_NgayVaoLam.Size = new System.Drawing.Size(112, 25);
            this.dtp_NgayVaoLam.TabIndex = 18;
            // 
            // txt_NgayThangNam
            // 
            this.txt_NgayThangNam.CustomFormat = "dd/MM/yyyy";
            this.txt_NgayThangNam.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_NgayThangNam.Location = new System.Drawing.Point(136, 86);
            this.txt_NgayThangNam.Name = "txt_NgayThangNam";
            this.txt_NgayThangNam.Size = new System.Drawing.Size(112, 25);
            this.txt_NgayThangNam.TabIndex = 17;
            // 
            // txt_LuongCB
            // 
            this.txt_LuongCB.Enabled = false;
            this.txt_LuongCB.Location = new System.Drawing.Point(354, 278);
            this.txt_LuongCB.Name = "txt_LuongCB";
            this.txt_LuongCB.Size = new System.Drawing.Size(111, 26);
            this.txt_LuongCB.TabIndex = 16;
            // 
            // lbl_LuongCB
            // 
            this.lbl_LuongCB.AutoSize = true;
            this.lbl_LuongCB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_LuongCB.Location = new System.Drawing.Point(254, 278);
            this.lbl_LuongCB.Name = "lbl_LuongCB";
            this.lbl_LuongCB.Size = new System.Drawing.Size(101, 19);
            this.lbl_LuongCB.TabIndex = 15;
            this.lbl_LuongCB.Text = "Lương cơ bản :";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Enabled = false;
            this.txt_Ma.Location = new System.Drawing.Point(136, 54);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(112, 26);
            this.txt_Ma.TabIndex = 14;
            // 
            // lbl_MaGV
            // 
            this.lbl_MaGV.AutoSize = true;
            this.lbl_MaGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MaGV.Location = new System.Drawing.Point(24, 57);
            this.lbl_MaGV.Name = "lbl_MaGV";
            this.lbl_MaGV.Size = new System.Drawing.Size(94, 19);
            this.lbl_MaGV.TabIndex = 13;
            this.lbl_MaGV.Text = "Mã giáo viên :";
            // 
            // lbl_NgayVaoLam
            // 
            this.lbl_NgayVaoLam.AutoSize = true;
            this.lbl_NgayVaoLam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_NgayVaoLam.Location = new System.Drawing.Point(254, 91);
            this.lbl_NgayVaoLam.Name = "lbl_NgayVaoLam";
            this.lbl_NgayVaoLam.Size = new System.Drawing.Size(100, 19);
            this.lbl_NgayVaoLam.TabIndex = 11;
            this.lbl_NgayVaoLam.Text = "Ngày vào làm :";
            // 
            // txt_HSL
            // 
            this.txt_HSL.Enabled = false;
            this.txt_HSL.Location = new System.Drawing.Point(135, 278);
            this.txt_HSL.Name = "txt_HSL";
            this.txt_HSL.Size = new System.Drawing.Size(112, 26);
            this.txt_HSL.TabIndex = 10;
            // 
            // lbl_HSL
            // 
            this.lbl_HSL.AutoSize = true;
            this.lbl_HSL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HSL.Location = new System.Drawing.Point(23, 278);
            this.lbl_HSL.Name = "lbl_HSL";
            this.lbl_HSL.Size = new System.Drawing.Size(90, 19);
            this.lbl_HSL.TabIndex = 9;
            this.lbl_HSL.Text = "Hệ số lương :";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(136, 118);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(329, 54);
            this.txt_DiaChi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(24, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ :";
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdb_Nu.Location = new System.Drawing.Point(396, 55);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(48, 23);
            this.rdb_Nu.TabIndex = 6;
            this.rdb_Nu.TabStop = true;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdb_Nam.Location = new System.Drawing.Point(333, 55);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(57, 23);
            this.rdb_Nam.TabIndex = 5;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(254, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính :";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(136, 22);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(329, 26);
            this.txt_HoTen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh :";
            // 
            // lbl_TenGV
            // 
            this.lbl_TenGV.AutoSize = true;
            this.lbl_TenGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TenGV.Location = new System.Drawing.Point(23, 25);
            this.lbl_TenGV.Name = "lbl_TenGV";
            this.lbl_TenGV.Size = new System.Drawing.Size(114, 19);
            this.lbl_TenGV.TabIndex = 0;
            this.lbl_TenGV.Text = "Họ tên giáo viên :";
            // 
            // grp_DSLH
            // 
            this.grp_DSLH.Controls.Add(this.TreeView_DSGV);
            this.grp_DSLH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_DSLH.ForeColor = System.Drawing.Color.Blue;
            this.grp_DSLH.Location = new System.Drawing.Point(108, 106);
            this.grp_DSLH.Name = "grp_DSLH";
            this.grp_DSLH.Size = new System.Drawing.Size(268, 403);
            this.grp_DSLH.TabIndex = 8;
            this.grp_DSLH.TabStop = false;
            this.grp_DSLH.Text = "Danh sách giáo viên";
            // 
            // TreeView_DSGV
            // 
            this.TreeView_DSGV.Location = new System.Drawing.Point(20, 26);
            this.TreeView_DSGV.Name = "TreeView_DSGV";
            this.TreeView_DSGV.Size = new System.Drawing.Size(227, 354);
            this.TreeView_DSGV.TabIndex = 0;
            // 
            // frm_ThongTinGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tab_GiaoVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThongTinGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ThongTinGiaoVien";
            this.Load += new System.EventHandler(this.frm_ThongTinGiaoVien_Load);
            this.tab_GiaoVien.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ts_ChucNang.ResumeLayout(false);
            this.ts_ChucNang.PerformLayout();
            this.grp_TTHS.ResumeLayout(false);
            this.grp_TTHS.PerformLayout();
            this.grp_DSLH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_GiaoVien;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grp_DSLH;
        private System.Windows.Forms.TreeView TreeView_DSGV;
        private System.Windows.Forms.GroupBox grp_TTHS;
        private System.Windows.Forms.ComboBox cbb_TrinhDo;
        private System.Windows.Forms.Label lbl_TrinhDo;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label lbl_CMND;
        private System.Windows.Forms.DateTimePicker dtp_NgayVaoLam;
        private System.Windows.Forms.DateTimePicker txt_NgayThangNam;
        private System.Windows.Forms.TextBox txt_LuongCB;
        private System.Windows.Forms.Label lbl_LuongCB;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label lbl_MaGV;
        private System.Windows.Forms.Label lbl_NgayVaoLam;
        private System.Windows.Forms.TextBox txt_HSL;
        private System.Windows.Forms.Label lbl_HSL;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TenGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip ts_ChucNang;
        private System.Windows.Forms.ToolStripButton tSb_Them;
        private System.Windows.Forms.ToolStripButton tSb_Xoa;
        private System.Windows.Forms.ToolStripButton tSb_Sua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Lương;
        private System.Windows.Forms.Label lbl_Luong;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.TextBox txt_LopHienTai;
        private System.Windows.Forms.Label lbl_TenLop;
    }
}