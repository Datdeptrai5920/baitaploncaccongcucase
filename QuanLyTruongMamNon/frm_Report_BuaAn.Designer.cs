namespace QuanLyTruongMamNon
{
    partial class frm_Report_BuaAn
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
            this.BuaAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoSoDuLieuDataSet = new QuanLyTruongMamNon.CoSoDuLieuDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BuaAnTableAdapter = new QuanLyTruongMamNon.CoSoDuLieuDataSetTableAdapters.BuaAnTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_Ngay = new System.Windows.Forms.ComboBox();
            this.cbb_LopHoc = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BuaAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoSoDuLieuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BuaAnBindingSource
            // 
            this.BuaAnBindingSource.DataMember = "BuaAn";
            this.BuaAnBindingSource.DataSource = this.CoSoDuLieuDataSet;
            // 
            // CoSoDuLieuDataSet
            // 
            this.CoSoDuLieuDataSet.DataSetName = "CoSoDuLieuDataSet";
            this.CoSoDuLieuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BuaAnBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTruongMamNon.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 103);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1083, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // BuaAnTableAdapter
            // 
            this.BuaAnTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày :";
            // 
            // cbb_Ngay
            // 
            this.cbb_Ngay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Ngay.FormattingEnabled = true;
            this.cbb_Ngay.Location = new System.Drawing.Point(288, 55);
            this.cbb_Ngay.Name = "cbb_Ngay";
            this.cbb_Ngay.Size = new System.Drawing.Size(121, 27);
            this.cbb_Ngay.TabIndex = 9;
            // 
            // cbb_LopHoc
            // 
            this.cbb_LopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LopHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LopHoc.FormattingEnabled = true;
            this.cbb_LopHoc.Location = new System.Drawing.Point(59, 55);
            this.cbb_LopHoc.Name = "cbb_LopHoc";
            this.cbb_LopHoc.Size = new System.Drawing.Size(121, 27);
            this.cbb_LopHoc.TabIndex = 8;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(433, 55);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 29);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Tìm kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lớp :";
            // 
            // frm_Report_BuaAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_Ngay);
            this.Controls.Add(this.cbb_LopHoc);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Report_BuaAn";
            this.Text = "frm_Report_BuaAn";
            this.Load += new System.EventHandler(this.frm_Report_BuaAn_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_Report_BuaAn_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.BuaAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoSoDuLieuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BuaAnBindingSource;
        private CoSoDuLieuDataSet CoSoDuLieuDataSet;
        private CoSoDuLieuDataSetTableAdapters.BuaAnTableAdapter BuaAnTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_Ngay;
        private System.Windows.Forms.ComboBox cbb_LopHoc;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
    }
}