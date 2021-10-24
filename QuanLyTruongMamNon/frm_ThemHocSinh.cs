using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.IO;

namespace QuanLyTruongMamNon
{
    public partial class frm_ThemHocSinh : Form
    {
        public frm_ThemHocSinh()
        {
            InitializeComponent();
        }
        bool _vt;
        string imgLoc = "";
        public bool vt
        {
            get { return _vt; }
            set { _vt = value; }
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True");
        //Data Source=(LocalDB)\v11.0;AttachDbFilename="C:\Users\Lucis Noctis\Desktop\QuanLyTruongMamNon\QuanLyTruongMamNon\CoSoDuLieu.mdf";Integrated Security=True
        //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True"
        //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lucis Noctis\Desktop\QuanLyTruongMamNon\QuanLyTruongMamNon\CoSoDuLieu.mdf;Integrated Security=True"
        private void frm_ThemHocSinh_Load(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void CapNhat()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lucis Noctis\Desktop\QuanLyTruongMamNon\QuanLyTruongMamNon\CoSoDuLieu.mdf;Integrated Security=True");
            SqlCommand cmd;
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT MaTre FROM HocSinh", con);
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                int i = dt.Rows.Count;
                int ma = 1;
                if(i>0)
                {
                    ma = int.Parse(dt.Rows[i-1]["MaTre"].ToString());
                    i = ma+1;
                    txt_MaTre.Text = i.ToString();
                }
                else if (i==0)
                {
                    txt_MaTre.Text = ma.ToString();
                }
                else
                    txt_MaTre.Text = ma.ToString();
                con.Close();

                con.Open();
                cmd = new SqlCommand("SELECT TenKhoi FROM KhoiHoc", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbb_KhoiHoc.Items.Add(dr["TenKhoi"]);
                }
                con.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
        }
        private string KT_GioiTinh(RadioButton e)
        {
            if (e.Checked == true)
                return "Nam";
            return "Nữ";
        }

        private string Lay_MaLop()
        {
            //string s = cbb_LopHoc.GetItemText(cbb_LopHoc.SelectedItem);
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lucis Noctis\Desktop\QuanLyTruongMamNon\QuanLyTruongMamNon\CoSoDuLieu.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT MaLop FROM LopHoc where TenLop = N'"+cbb_LopHoc.Text+"'", con);
            //cmd.Parameters.AddWithValue("@TenLop", s);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())// && dr.HasRows)
            {
                return dr["MaLop"].ToString();
            }
            //string malop = (string)cmd.ExecuteScalar();
            con.Close();
            return null;
        }

        private void cbb_KhoiHoc_TextChanged(object sender, EventArgs e)
        {
            cbb_LopHoc.Items.Clear();
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lucis Noctis\Desktop\QuanLyTruongMamNon\QuanLyTruongMamNon\CoSoDuLieu.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TenLop, TenKhoi FROM LopHoc, KhoiHoc WHERE LopHoc.MaKhoi = KhoiHoc.MaKhoi AND TenKhoi= N'"+cbb_KhoiHoc.Text+"'", con);
            //cmd.Parameters.AddWithValue("@TenKhoi", cbb_KhoiHoc.Text);
            SqlDataReader dre = cmd.ExecuteReader();
            while (dre.Read())
            {
                cbb_LopHoc.Items.Add(dre["TenLop"]);
            }
            con.Close();
        }

        private void Space(GroupBox grp)
        {
            foreach(Control ctr in grp.Controls)
            {
                 if (ctr.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)ctr;
                    t.Text = "";
                }
            }
        }
        private void bt_Them_Click(object sender, EventArgs e)
        {
            bool k = true;
            foreach(Control ctr in groupBox1.Controls)
            {
                if(ctr.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)ctr;
                    if (t.Text == string.Empty)
                        k = false;
                }
            }
            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)ctr;
                    if (t.Text == string.Empty)
                        k = false;
                }
                if (ctr.GetType() == typeof(ComboBox))
                {
                    ComboBox t = (ComboBox)ctr;
                    if (t.Text == string.Empty)
                        k = false;
                }
            }
            if (!k)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin.");
            }
            else
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                SqlCommand cmd = new SqlCommand("INSERT INTO HocSinh(MaTre, TenTre, NgaySinh, GioiTinh, DiaChi, MaLop, NgayNhapHoc, Hinh) VALUES (@MaTre, @TenTre, @NgaySinh, @GioiTinh, @DiaChi, @MaLop, @NgayNhapHoc, @Hinh)", con);
                cmd.Parameters.Add("@MaTre", txt_MaTre.Text);
                cmd.Parameters.Add("@TenTre", txt_HoTen.Text);
                cmd.Parameters.Add("@NgaySinh", txt_NgaySinh.Text);
                cmd.Parameters.Add("@GioiTinh", KT_GioiTinh(rdb_Nam));
                cmd.Parameters.Add("@DiaChi", txt_DiaChi.Text);
                cmd.Parameters.Add("@MaLop", Lay_MaLop());
                cmd.Parameters.Add("@NgayNhapHoc", DateTime.Now.ToString("dd/MM/yyyy"));
                cmd.Parameters.Add("@Hinh", img);

                SqlCommand cmd1 = new SqlCommand("INSERT INTO PhuHuynh(MaTre, HoTenCha, NgheNghiepCha, SDTCHa, HoTenMe, NgheNghiepMe, SDTMe) VALUES (@MaTre, @HoTenCha, @NgheNghiepCha, @SDTCHa, @HoTenMe, @NgheNghiepMe, @SDTMe)", con);
                cmd1.Parameters.Add("@MaTre", txt_MaTre.Text);
                cmd1.Parameters.Add("@HoTenCha", txt_HoTenCha.Text);
                cmd1.Parameters.Add("@NgheNghiepCha", txt_NgheNghiepCha.Text);
                cmd1.Parameters.Add("@SDTCha", txt_SDTCha.Text);
                cmd1.Parameters.Add("@HoTenMe", txt_HoTenMe.Text);
                cmd1.Parameters.Add("@NgheNghiepMe", txt_NgheNghiepMe.Text);
                cmd1.Parameters.Add("@SDTMe", txt_SDTMe.Text);
                try
                {
                    con.Open();
                    //if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery()>0)
                    //    MessageBox.Show("Đã thêm thành công vào cơ sỡ dữ liệu.");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Đã thêm thành công vào cơ sỡ dữ liệu.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }

                txt_MaTre.Text = ""; txt_HoTenCha.Text = "";
                txt_HoTen.Text = ""; txt_HoTenMe.Text = "";
                txt_NgaySinh.Text = ""; txt_NgheNghiepCha.Text="";
                rdb_Nam.Checked = false; txt_NgheNghiepMe.Text ="";
                rdb_Nu.Checked = false; txt_SDTCha.Text="";
                txt_DiaChi.Text = ""; txt_SDTMe.Text="";
                cbb_KhoiHoc.Text = ""; cbb_LopHoc.Text = "";
                con.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(MaTre) FROM HocSinh", con);
                int count = (int)cmd2.ExecuteScalar();
                txt_MaTre.Text = (count + 1).ToString();
                con.Close();
            }
        }

        private void frm_ThemHocSinh_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.Vertical);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void txt_SDTCha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '-')*/)
            {
                e.Handled = true;
            }
        }

        private void txt_SDTMe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '-')*/)
            {
                e.Handled = true;
            }
        }

        private void bt_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            open.Title = "Chọn ảnh đại diện";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imgLoc = open.FileName.ToString();
                imgBox.ImageLocation = imgLoc;
            }
        }

    }
}
