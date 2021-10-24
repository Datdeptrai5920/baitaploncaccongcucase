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
    public partial class frm_Report_BuaAn : Form
    {
        public frm_Report_BuaAn()
        {
            InitializeComponent();
        }

        private void frm_Report_BuaAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CoSoDuLieuDataSet.BuaAn' table. You can move, or remove it, as needed.
            this.BuaAnTableAdapter.Fill(this.CoSoDuLieuDataSet.BuaAn);
            dv = new DataView(this.CoSoDuLieuDataSet.BuaAn);
            this.BuaAnBindingSource.DataSource = dv;
            this.reportViewer1.RefreshReport();
            LoadDataInto_ComboBox_LopHoc();
            LoadDataInto_ComboBox_Ngay();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True");
        //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True"
        //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lucis Noctis\Desktop\QuanLyTruongMamNon\QuanLyTruongMamNon\CoSoDuLieu.mdf;Integrated Security=True"
        private void LoadDataInto_ComboBox_LopHoc()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM LopHoc", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbb_LopHoc.DataSource = dt;
                cbb_LopHoc.DisplayMember = "TenLop";
                cbb_LopHoc.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cbb_LopHoc.SelectedValue = -1;
        }

        private void LoadDataInto_ComboBox_Ngay()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT NgayThangNam FROM BuaAn GROUP BY NgayThangNam", con);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cbb_Ngay.Items.Add(sdr["NgayThangNam"].ToString());
                }
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        DataView dv;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cbb_LopHoc.Text == string.Empty || cbb_Ngay.Text == string.Empty)
                MessageBox.Show("Hãy chọn đầy đủ thông tin.");
            else
            {
                dv.RowFilter = string.Format("MaLop = '{0}' AND NgayThangNam = '{1}'", cbb_LopHoc.SelectedValue, cbb_Ngay.Text);
                this.reportViewer1.RefreshReport();
            }
        }

        private void frm_Report_BuaAn_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        
    }
}
