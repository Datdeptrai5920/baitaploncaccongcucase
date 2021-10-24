using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongMamNon
{
    public partial class frm_Report_HocPhi : Form
    {
        public frm_Report_HocPhi()
        {
            InitializeComponent();
        }
        DataView dv;
        private void frm_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CoSoDuLieuDataSet.HocPhi_HocSinh' table. You can move, or remove it, as needed.
            this.HocPhi_HocSinhTableAdapter.Fill(this.CoSoDuLieuDataSet.HocPhi_HocSinh);
            // TODO: This line of code loads data into the 'CoSoDuLieuDataSet.DataTable2' table. You can move, or remove it, as needed.
            //this.DataTable2TableAdapter.Fill(this.CoSoDuLieuDataSet.DataTable2);
            // TODO: This line of code loads data into the 'CoSoDuLieuDataSet.TK_GV' table. You can move, or remove it, as needed.
            //this.TK_GVTableAdapter.Fill(this.CoSoDuLieuDataSet.TK_GV);
            // TODO: This line of code loads data into the 'CoSoDuLieuDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            //this.TaiKhoanTableAdapter.Fill(this.CoSoDuLieuDataSet.HocPhi_HocSinh);
            dv = new DataView(this.CoSoDuLieuDataSet.HocPhi_HocSinh);
            this.HocPhi_HocSinhBindingSource.DataSource = dv;
            this.reportViewer1.RefreshReport();
            LoadDataInto_ComboBox_LopHoc();
            LoadDataInto_ComboBox_ThangNam();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cbb_LopHoc.Text == string.Empty || cbb_ThangNam.Text == string.Empty)
                MessageBox.Show("Hãy chọn đầy đủ thông tin.");
            else
            {
                dv.RowFilter = string.Format("TenLop = '{0}' AND ThangNam = '{1}'", cbb_LopHoc.Text, cbb_ThangNam.Text);
                this.reportViewer1.RefreshReport();
            }
            ////TenLop like '%{0}%'", textEdit1.Text
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True");
        /// <summary>
        //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True"
        //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lucis Noctis\Desktop\QuanLyTruongMamNon\QuanLyTruongMamNon\CoSoDuLieu.mdf;Integrated Security=True"
        /// </summary>
        private void LoadDataInto_ComboBox_LopHoc()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT TenLop FROM LopHoc", con);
                if(con.State == ConnectionState.Closed)
                    con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    cbb_LopHoc.Items.Add(sdr["TenLop"].ToString());
                }
                if(con.State == ConnectionState.Open)
                    con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDataInto_ComboBox_ThangNam()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ThangNam FROM HocPhi GROUP BY ThangNam", con);
                if(con.State == ConnectionState.Closed)
                    con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    cbb_ThangNam.Items.Add(sdr["ThangNam"].ToString());
                }
                if(con.State == ConnectionState.Open)
                    con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_Report_HocPhi_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        
    }
}
