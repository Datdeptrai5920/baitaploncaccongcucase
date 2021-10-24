using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongMamNon
{
    public partial class frm_ThemGiaoVien : MyFormPage
    {
        public frm_ThemGiaoVien()
        {
            InitializeComponent();
            this.pnl = panel1;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True");
        bool _vt;
        public bool vt
        {
            get { return _vt; }
            set { _vt = value; }
        }
        private string KT_GioiTinh(RadioButton e)
        {
            if (e.Checked == true)
                return "Nam";
            return "Nữ";
        }

        private void clear(GroupBox grp_TTHS)
        {
            foreach (Control ctr in grp_TTHS.Controls)
            {
                if (ctr.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)ctr;
                    t.Clear();
                }
                if (ctr.GetType() == typeof(DateTimePicker))
                {
                    DateTimePicker t = (DateTimePicker)ctr;
                    t.Value = DateTime.Today;
                }
                if (ctr.GetType() == typeof(ComboBox))
                {
                    ComboBox t = (ComboBox)ctr;
                    t.Text = string.Empty;
                }
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            
            bool k = true;
            foreach(Control ctr in grp_TTCN.Controls)
            {
                if(ctr.GetType() == typeof(TextBox))
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

                //if (rdb_Nam.Checked == false && rdb_Nu.Checked == false)
                //    k = false;
            }

            foreach (Control ctr in grp_TTGV.Controls)
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
            if (imgLoc == "")
                k = false;
            if (!k)
            {
                MessageBox.Show("Bạn hãy điền đầy đủ thông tin.");
            }
            else
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO GiaoVien(MaGV, TenGV, NgaySinh, GioiTinh, DiaChi, SDT, HSL, NgayBatDau, LuongCB, CMND, TrinhDo, Hinh) VALUES(@MaGV, @TenGV, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @HSL, @NgayBatDau, @LuongCB, @CMND, @TrinhDo, @Hinh)", con);
                    cmd.Parameters.Add("@MaGV", txt_MaGV.Text);
                    cmd.Parameters.Add("@TenGV", txt_TenGV.Text);
                    cmd.Parameters.Add("@NgaySinh", dtp_NgaySinh.Text);
                    cmd.Parameters.Add("@GioiTinh", KT_GioiTinh(nam));

                    cmd.Parameters.Add("@DiaChi", txt_DiaChi.Text);
                    cmd.Parameters.Add("@SDT", txt_SDT.Text);
                    cmd.Parameters.Add("@HSL", txt_HSL.Text);
                    cmd.Parameters.Add("@NgayBatDau", dtp_NgayVaoLam.Text);
                    cmd.Parameters.Add("@LuongCB", txt_LuongCB.Text);
                    //cmd.Parameters.Add("@MaLop", null);
                    cmd.Parameters.Add("@CMND", txt_CMND.Text);
                    cmd.Parameters.Add("@TrinhDo", cbb_TrinhDo.Text);
                    cmd.Parameters.Add("@Hinh", img);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        if(MessageBox.Show("Đã thêm thành công vào cơ sỡ dữ liệu./nGiáo viên này hiện vẫn chưa có lớp chủ nhiệm. Bạn có muốn phân công ngay bây giờ?", "Thông báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            frm_PhanCong frm = new frm_PhanCong();
                            frm.vt = _vt;
                            frm.Show();
                        }
                        clear(grp_TTCN);
                        clear(grp_TTGV);
                    }
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã giáo viên này đã tồn tại. Không thể thêm mới.", "Thông báo");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
               
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.Vertical);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.OrangeRed, Color.White, LinearGradientMode.Vertical);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.DodgerBlue, Color.White, LinearGradientMode.Vertical);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }


        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '-')*/)
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '-')*/)
            {
                e.Handled = true;
            }
        }

        private void txt_HSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_LuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '-')*/)
            {
                e.Handled = true;
            }
        }

        private void frm_ThemGiaoVien_Load(object sender, EventArgs e)
        {
            cbb_TrinhDo.Items.AddRange(new object[] { "Đại học", "Cao đẳng", "Trung cấp chuyên nghiệp" });
        }

        string imgLoc = "";
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

        private void LoadDataInto_lst_GV()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaGV, TenGV FROM GiaoVien", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    ListViewItem item = new ListViewItem(sdr["MaGV"].ToString());
                    item.SubItems.Add(sdr["TenGV"].ToString());
                    lst_GV.Items.Add(item);
                }
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_TenGV_Click(object sender, EventArgs e)
        {
            LoadDataInto_lst_GV();
            cbb_TrinhDo.Items.AddRange(new object[] { "Đại học", "Cao đẳng", "Trung cấp chuyện nghiệp" });
        }

    }
}
