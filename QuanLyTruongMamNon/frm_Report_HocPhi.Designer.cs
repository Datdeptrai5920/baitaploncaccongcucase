namespace QuanLyTruongMamNon
{
    partial class frm_Report_HocPhi
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HocPhi_HocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoSoDuLieuDataSet = new QuanLyTruongMamNon.CoSoDuLieuDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TK_GVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaiKhoanTableAdapter = new QuanLyTruongMamNon.CoSoDuLieuDataSetTableAdapters.TaiKhoanTableAdapter();
            this.TK_GVTableAdapter = new QuanLyTruongMamNon.CoSoDuLieuDataSetTableAdapters.TK_GVTableAdapter();
            this.DataTable2TableAdapter = new QuanLyTruongMamNon.CoSoDuLieuDataSetTableAdapters.DataTable2TableAdapter();
            this.HocPhi_HocSinhTableAdapter = new QuanLyTruongMamNon.CoSoDuLieuDataSetTableAdapters.HocPhi_HocSinhTableAdapter();
            this.cbb_LopHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_ThangNam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.HocPhi_HocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoSoDuLieuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TK_GVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HocPhi_HocSinhBindingSource
            // 
            this.HocPhi_HocSinhBindingSource.DataMember = "HocPhi_HocSinh";
            this.HocPhi_HocSinhBindingSource.DataSource = this.CoSoDuLieuDataSet;
            // 
            // CoSoDuLieuDataSet
            // 
            this.CoSoDuLieuDataSet.DataSetName = "CoSoDuLieuDataSet";
            this.CoSoDuLieuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_HocPhi";
            reportDataSource1.Value = this.HocPhi_HocSinhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTruongMamNon.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(809, 364);
            this.reportViewer1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(478, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 29);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Tìm kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.CoSoDuLieuDataSet;
            // 
            // TK_GVBindingSource
            // 
            this.TK_GVBindingSource.DataMember = "TK_GV";
            this.TK_GVBindingSource.DataSource = this.CoSoDuLieuDataSet;
            // 
            // TaiKhoanBindingSource
            // 
            this.TaiKhoanBindingSource.DataMember = "TaiKhoan";
            this.TaiKhoanBindingSource.DataSource = this.CoSoDuLieuDataSet;
            // 
            // TaiKhoanTableAdapter
            // 
            this.TaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // TK_GVTableAdapter
            // 
            this.TK_GVTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // HocPhi_HocSinhTableAdapter
            // 
            this.HocPhi_HocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // cbb_LopHoc
            // 
            this.cbb_LopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LopHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LopHoc.FormattingEnabled = true;
            this.cbb_LopHoc.Location = new System.Drawing.Point(59, 16);
            this.cbb_LopHoc.Name = "cbb_LopHoc";
            this.cbb_LopHoc.Size = new System.Drawing.Size(121, 27);
            this.cbb_LopHoc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lớp :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tháng :";
            // 
            // cbb_ThangNam
            // 
            this.cbb_ThangNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ThangNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ThangNam.FormattingEnabled = true;
            this.cbb_ThangNam.Location = new System.Drawing.Point(315, 16);
            this.cbb_ThangNam.Name = "cbb_ThangNam";
            this.cbb_ThangNam.Size = new System.Drawing.Size(121, 27);
            this.cbb_ThangNam.TabIndex = 5;
            // 
            // frm_Report_HocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_ThangNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_LopHoc);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Report_HocPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Report";
            this.Load += new System.EventHandler(this.frm_Report_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_Report_HocPhi_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.HocPhi_HocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoSoDuLieuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TK_GVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TaiKhoanBindingSource;
        private CoSoDuLieuDataSet CoSoDuLieuDataSet;
        private CoSoDuLieuDataSetTableAdapters.TaiKhoanTableAdapter TaiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource TK_GVBindingSource;
        private CoSoDuLieuDataSetTableAdapters.TK_GVTableAdapter TK_GVTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private CoSoDuLieuDataSetTableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
        private System.Windows.Forms.BindingSource HocPhi_HocSinhBindingSource;
        private CoSoDuLieuDataSetTableAdapters.HocPhi_HocSinhTableAdapter HocPhi_HocSinhTableAdapter;
        private System.Windows.Forms.ComboBox cbb_LopHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_ThangNam;
    }
}