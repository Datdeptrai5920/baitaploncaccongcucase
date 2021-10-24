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

namespace QuanLyTruongMamNon
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        bool _vt = true;
        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            lbl_ThongBao.BackColor = System.Drawing.Color.Transparent;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frm_ThongTinTre frm = new frm_ThongTinTre();
            frm.Show();
        }
        private void bt_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\CoSoDuLieu.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TaiKhoan='" + txt_TaiKhoan.Text + "' AND MatKhau='" + txt_MatKhau.Text + "'", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    mS.Visible = true;
                    if (panel1.Width == 0)
                        timer1.Start();
                    if (sdr["VaiTro"].ToString() == "Client")
                        _vt = false;
                    else
                        _vt = true;
                }
                else
                    lbl_ThongBao.Text = "Tài khoản hoặc mật khẩu không chính xác.";
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kết nối tới cơ sở dữ liệu thất bại. Vui lòng thủ lại sau.");
                Application.Exit();
            }
           
        }
        private void bt_QLT_Click(object sender, EventArgs e)
        {
            frm_ThongTinTre frm = new frm_ThongTinTre();
            frm.vt = _vt;
            frm.Show();
        }
        private void bt_QLKL_Click(object sender, EventArgs e)
        {
            frm_ThemGiaoVien_update_ frm = new frm_ThemGiaoVien_update_();
            frm.vt = _vt;
            frm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Width < 385)
            {
                panel1.Width += 10;
                if (panel1.Width == 50)
                    timer2.Start();
                if (panel1.Width >= 385)
                    timer1.Stop();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel2.Width < 385)
            {
                panel2.Width += 10;
                if (panel2.Width == 50)
                    timer3.Start();
                if (panel2.Width >= 385)
                    timer2.Stop();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.OrangeRed, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.DodgerBlue, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (panel3.Width < 385)
            {
                panel3.Width += 10;
                if (panel3.Width == 50)
                    timer4.Start();
                if (panel3.Width >= 385)
                    timer3.Stop();
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Yellow, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (panel4.Width < 385)
            {
                panel4.Width += 10;
                if (panel4.Width == 50)
                    timer5.Start();
                if (panel4.Width >= 385)
                    timer4.Stop();
            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (panel5.Width < 385)
            {
                panel5.Width += 10;
                if (panel5.Width >= 385)
                    timer5.Stop();
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightPink, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Violet, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_KhoiLop frm = new frm_KhoiLop();
            frm.vt = _vt;
            frm.Show();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_BuaAn frm = new frm_BuaAn();
            frm.vt = _vt;
            frm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                frm_TaiKhoan frm = new frm_TaiKhoan();
                frm.Show();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //frm_DangNhap frm = new frm_DangNhap();
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frm_DangNhap")
                    Application.OpenForms[i].Close();
            }
            timer6.Start();
            txt_TaiKhoan.Text = string.Empty;
            txt_MatKhau.Text = string.Empty;
            txt_TaiKhoan.Focus();
            lbl_ThongBao.Text = "";
            mS.Visible = false;
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (panel1.Width > 0)
            {
                panel1.Width -= 10;
                if (panel1.Width <= 335)
                    timer7.Start();
                if (panel1.Width <=0)
                    timer6.Stop();
            }
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            if (panel2.Width > 0)
            {
                panel2.Width -= 10;
                if (panel2.Width <= 335)
                    timer8.Start();
                if (panel2.Width <= 0)
                    timer7.Stop();
            }
        }
        private void timer8_Tick(object sender, EventArgs e)
        {
            if (panel3.Width > 0)
            {
                panel3.Width -= 10;
                if (panel3.Width <= 335)
                    timer9.Start();
                if (panel3.Width <= 0)
                    timer8.Stop();
            }
        }
        private void timer9_Tick(object sender, EventArgs e)
        {
            if (panel4.Width > 0)
            {
                panel4.Width -= 10;
                if (panel4.Width <= 335)
                    timer10.Start();
                if (panel4.Width <= 0)
                    timer9.Stop();
            }
        }
        private void timer10_Tick(object sender, EventArgs e)
        {
            if (panel5.Width > 0)
            {
                panel5.Width -= 10;
                if (panel5.Width <= 0)
                    timer10.Stop();
            }
        }
        private void bt_ThayDoi_Click(object sender, EventArgs e)
        {
            if (txt_tk.Text == string.Empty || txt_mk1.Text == string.Empty || txt_mk2.Text == string.Empty || txt_mkm.Text == string.Empty)
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.");
            else if (txt_mk1.Text != txt_mk2.Text)
                MessageBox.Show("Xác nhận mật khẩu cũ không chính xác.");
            else
            {
                try
                {
                    int i = 0;
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM TaiKhoan WHERE TaiKhoan = '" + txt_tk.Text + "' AND MatKhau='" + txt_mk1.Text + "'", con);
                    if (cmd1.ExecuteNonQuery() > 0)
                        i = 1;
                    con.Close();
                    if (i == 1)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE TaiKhoan SET MatKhau = '" + txt_mkm.Text + "' WHERE TaiKhoan = '" + txt_tk.Text + "' AND MatKhau='" + txt_mk1.Text + "'", con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thay đổi thành công.");
                            timer12.Start();
                        }
                        con.Close();
                        txt_tk.Text = string.Empty; txt_mk1.Text = string.Empty;
                        txt_mk2.Text = string.Empty; txt_mkm.Text = string.Empty;
                    }
                    else
                        MessageBox.Show("Tài khoản này không tồn tại.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void timer11_Tick(object sender, EventArgs e)
        {
            if(panel6.Width < 385)
            {
                panel6.Width += 10;
                if (panel6.Width >= 385)
                    timer11.Stop();
            }
        }
        private void timer12_Tick(object sender, EventArgs e)
        {
            if (panel6.Width > 0)
            {
                panel6.Width -= 10;
                if (panel6.Width <= 0)
                    timer12.Stop();
            }
        }
        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        private void đốiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer11.Start();
        }
        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            timer12.Start();
        }
    }
}
