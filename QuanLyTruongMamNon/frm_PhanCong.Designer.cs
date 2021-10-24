namespace QuanLyTruongMamNon
{
    partial class frm_PhanCong
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
            this.dGV_PhanCong = new System.Windows.Forms.DataGridView();
            this.col_MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenLop = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_KhoiHoc = new System.Windows.Forms.ComboBox();
            this.bt_HienThi = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_PhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_PhanCong
            // 
            this.dGV_PhanCong.AllowUserToAddRows = false;
            this.dGV_PhanCong.AllowUserToDeleteRows = false;
            this.dGV_PhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_PhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_PhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaGV,
            this.col_TenGV,
            this.col_MaLop,
            this.col_TenLop});
            this.dGV_PhanCong.Location = new System.Drawing.Point(13, 77);
            this.dGV_PhanCong.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_PhanCong.Name = "dGV_PhanCong";
            this.dGV_PhanCong.Size = new System.Drawing.Size(682, 234);
            this.dGV_PhanCong.TabIndex = 0;
            this.dGV_PhanCong.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_PhanCong_CellValueChanged);
            this.dGV_PhanCong.CurrentCellDirtyStateChanged += new System.EventHandler(this.dGV_PhanCong_CurrentCellDirtyStateChanged);
            this.dGV_PhanCong.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dGV_PhanCong_EditingControlShowing);
            // 
            // col_MaGV
            // 
            this.col_MaGV.DataPropertyName = "MaGV";
            this.col_MaGV.HeaderText = "Mã giáo viên";
            this.col_MaGV.Name = "col_MaGV";
            // 
            // col_TenGV
            // 
            this.col_TenGV.DataPropertyName = "TenGV";
            this.col_TenGV.HeaderText = "Tên giáo viên";
            this.col_TenGV.Name = "col_TenGV";
            // 
            // col_MaLop
            // 
            this.col_MaLop.DataPropertyName = "MaLop";
            this.col_MaLop.HeaderText = "Mã lớp hiện tại";
            this.col_MaLop.Name = "col_MaLop";
            // 
            // col_TenLop
            // 
            this.col_TenLop.DataPropertyName = "MaLop";
            this.col_TenLop.HeaderText = "Tên lớp hiện tại";
            this.col_TenLop.Name = "col_TenLop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khối học : ";
            // 
            // cbb_KhoiHoc
            // 
            this.cbb_KhoiHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_KhoiHoc.FormattingEnabled = true;
            this.cbb_KhoiHoc.Location = new System.Drawing.Point(96, 24);
            this.cbb_KhoiHoc.Name = "cbb_KhoiHoc";
            this.cbb_KhoiHoc.Size = new System.Drawing.Size(140, 27);
            this.cbb_KhoiHoc.TabIndex = 2;
            // 
            // bt_HienThi
            // 
            this.bt_HienThi.ForeColor = System.Drawing.Color.MediumBlue;
            this.bt_HienThi.Location = new System.Drawing.Point(260, 24);
            this.bt_HienThi.Name = "bt_HienThi";
            this.bt_HienThi.Size = new System.Drawing.Size(112, 27);
            this.bt_HienThi.TabIndex = 3;
            this.bt_HienThi.Text = "Hiển thị";
            this.bt_HienThi.UseVisualStyleBackColor = true;
            this.bt_HienThi.Click += new System.EventHandler(this.bt_HienThi_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.ForeColor = System.Drawing.Color.MediumBlue;
            this.bt_Luu.Location = new System.Drawing.Point(397, 24);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(112, 27);
            this.bt_Luu.TabIndex = 4;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = true;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // frm_PhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(708, 337);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.bt_HienThi);
            this.Controls.Add(this.cbb_KhoiHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_PhanCong);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_PhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công";
            this.Load += new System.EventHandler(this.frm_PhanCong_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_PhanCong_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_PhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_PhanCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_KhoiHoc;
        private System.Windows.Forms.Button bt_HienThi;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaLop;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_TenLop;
    }
}