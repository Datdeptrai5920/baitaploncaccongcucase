using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace QuanLyTruongMamNon
{
    public partial class frm_BuaAn : Form
    {
        public frm_BuaAn()
        {
            InitializeComponent();
        }

        private bool _vt;
        public bool vt
        {
            get { return _vt; }
            set { _vt = value; }
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True");
        //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True"
        //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lucis Noctis\Desktop\QuanLyTruongMamNon\QuanLyTruongMamNon\CoSoDuLieu.mdf;Integrated Security=True"
        private void CapNhat_CBB()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MaLop, TenLop FROM LopHoc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                cbb_TenLop.DataSource = dt;
                cbb_TenLop.DisplayMember = "TenLop";
                cbb_TenLop.ValueMember = "MaLop";
            }
        }

        private void frm_BuaAn_Load(object sender, EventArgs e)
        {
            CapNhat_CBB();
            //rtxt_BuaSang.Enabled = false; rtxt_BuaSang.Text = string.Empty;
            //rtxt_BuaTrua.Enabled = false; rtxt_BuaTrua.Text = string.Empty;
            //rtxt_BuaChieu.Enabled = false; rtxt_BuaChieu.Text = string.Empty;
            //txt_CpSang.Enabled = false; txt_CpSang.Text = string.Empty;
            //txt_CpTrua.Enabled = false; txt_CpTrua.Text = string.Empty;
            //txt_CpChieu.Enabled = false; txt_CpChieu.Text = string.Empty;
            cbb_TenLop.SelectedValue = -1;
            dtp_NgayThangNam.Value = DateTime.Today;
            bt_Xoa.Enabled = false;
            bt_Sua.Enabled = false;
        }
        private void txt_CpSang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '-')*/)
            {
                e.Handled = true;
            }
        }

        private void txt_CpTrua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '-')*/)
            {
                e.Handled = true;
            }
        }

        private void txt_CpChieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '-')*/)
            {
                e.Handled = true;
            }
        }

        private void txt_CpSang_TextChanged(object sender, EventArgs e)
        {
            int TongTien = 0;
            if (txt_CpSang.Text == string.Empty)
                TongTien += 0;
            else
            {
                int CpSang = int.Parse(txt_CpSang.Text);
                TongTien += CpSang;
            }
            if (txt_CpTrua.Text == string.Empty)
                TongTien += 0;
            else
            {
                int CpTrua = int.Parse(txt_CpTrua.Text);
                TongTien += CpTrua;
            }
            if (txt_CpChieu.Text == string.Empty)
                TongTien += 0;
            else
            {
                int CpChieu = int.Parse(txt_CpChieu.Text);
                TongTien += CpChieu;
            }
            txt_TongChiPhi.Text = TongTien.ToString();
        }

        private void txt_CpTrua_TextChanged(object sender, EventArgs e)
        {
            int TongTien = 0;
            if (txt_CpSang.Text == string.Empty)
                TongTien += 0;
            else
            {
                int CpSang = int.Parse(txt_CpSang.Text);
                TongTien += CpSang;
            }
            if (txt_CpTrua.Text == string.Empty)
                TongTien += 0;
            else
            {
                int CpTrua = int.Parse(txt_CpTrua.Text);
                TongTien += CpTrua;
            }
            if (txt_CpChieu.Text == string.Empty)
                TongTien += 0;
            else
            {
                int CpChieu = int.Parse(txt_CpChieu.Text);
                TongTien += CpChieu;
            }
            txt_TongChiPhi.Text = TongTien.ToString();
        }

        private void txt_CpChieu_TextChanged(object sender, EventArgs e)
        {
            int TongTien = 0;
            if (txt_CpSang.Text == string.Empty)
                TongTien += 0;
            else
            {
                int CpSang = int.Parse(txt_CpSang.Text);
                TongTien += CpSang;
            }
            if (txt_CpTrua.Text == string.Empty)
                TongTien += 0;
            else
            {
                int CpTrua = int.Parse(txt_CpTrua.Text);
                TongTien += CpTrua;
            }
            if (txt_CpChieu.Text == string.Empty)
                TongTien += 0;
            else
            {
                int CpChieu = int.Parse(txt_CpChieu.Text);
                TongTien += CpChieu;
            }
            txt_TongChiPhi.Text = TongTien.ToString();
        }

        private void cbb_TenLop_TextChanged(object sender, EventArgs e)
        {
            if (cbb_TenLop.SelectedValue != null)
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM BuaAn WHERE MaLop = '" + cbb_TenLop.SelectedValue + "' AND NgayThangNam = '" + dtp_NgayThangNam.Value.ToString("dd/MM/yyyy") + "'", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        rtxt_BuaSang.Enabled = false;
                        rtxt_BuaTrua.Enabled = false;
                        rtxt_BuaChieu.Enabled = false;
                        txt_CpSang.Enabled = false;
                        txt_CpTrua.Enabled = false;
                        txt_CpChieu.Enabled = false;
                        txt_TongChiPhi.Enabled = false;
                        rtxt_BuaSang.Text = sdr["BuaSang"].ToString();
                        txt_CpSang.Text = sdr["CpBuaSang"].ToString();
                        rtxt_BuaTrua.Text = sdr["BuaTrua"].ToString();
                        txt_CpTrua.Text = sdr["CpBuaTrua"].ToString();
                        rtxt_BuaChieu.Text = sdr["BuaChieu"].ToString();
                        txt_CpChieu.Text = sdr["CpBuaChieu"].ToString();
                        txt_TongChiPhi.Text = sdr["TongCp"].ToString();
                        bt_Them.Enabled = false;
                        bt_Xoa.Enabled = true;
                        bt_Sua.Enabled = true; bt_Sua.Text = "Sửa";
                    }
                    else
                    {
                        rtxt_BuaSang.Enabled = true; rtxt_BuaSang.Text = string.Empty;
                        rtxt_BuaTrua.Enabled = true; rtxt_BuaTrua.Text = string.Empty;
                        rtxt_BuaChieu.Enabled = true; rtxt_BuaChieu.Text = string.Empty;
                        txt_CpSang.Enabled = true; txt_CpSang.Text = string.Empty;
                        txt_CpTrua.Enabled = true; txt_CpTrua.Text = string.Empty;
                        txt_CpChieu.Enabled = true; txt_CpChieu.Text = string.Empty;
                        bt_Them.Enabled = true;
                        bt_Xoa.Enabled = false;
                        bt_Sua.Enabled = false;
                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                //rtxt_BuaSang.Enabled = false;
                //rtxt_BuaTrua.Enabled = false;
                //rtxt_BuaChieu.Enabled = false;
                //txt_CpSang.Enabled = false;
                //txt_CpTrua.Enabled = false;
                //txt_CpChieu.Enabled = false;
                //bt_Them.Text = "Thêm";
                //bt_Xoa.Enabled = true;
                //bt_Sua.Enabled = true;
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else { 
            bool k = true;
            //if (bt_Them.Text == "Thêm")
            //{
            //    rtxt_BuaSang.Enabled = true; rtxt_BuaSang.Text = string.Empty;
            //    rtxt_BuaTrua.Enabled = true; rtxt_BuaTrua.Text = string.Empty;
            //    rtxt_BuaChieu.Enabled = true; rtxt_BuaChieu.Text = string.Empty;
            //    txt_CpSang.Enabled = true; txt_CpSang.Text = string.Empty;
            //    txt_CpTrua.Enabled = true; txt_CpTrua.Text = string.Empty;
            //    txt_CpChieu.Enabled = true; txt_CpChieu.Text = string.Empty;
            //    cbb_TenLop.SelectedValue = -1;
            //    dtp_NgayThangNam.Value = DateTime.Today;
            //    bt_Them.Text = "Lưu";
            //    bt_Xoa.Enabled = false;
            //    bt_Sua.Enabled = false;
            //}
            //else if (bt_Them.Text == "Lưu")
            //{
                foreach (Control ctr in grp_TTBA.Controls)
                {
                    if (ctr.GetType() == typeof(TextBox))
                    {
                        TextBox t = (TextBox)ctr;
                        if (t.Text == string.Empty)                           
                            k = false;
                    }
                    if (ctr.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox t = (RichTextBox)ctr;
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
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin.");
                }
                else
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO BuaAn VALUES('" + cbb_TenLop.SelectedValue + "', '" + dtp_NgayThangNam.Text + "', N'" + rtxt_BuaSang.Text + "', N'" + rtxt_BuaTrua.Text + "', N'" + rtxt_BuaChieu.Text + "', '" + int.Parse(txt_CpSang.Text) + "', '" + int.Parse(txt_CpTrua.Text) + "', '" + int.Parse(txt_CpChieu.Text) + "', '" + int.Parse(txt_TongChiPhi.Text) + "')", con);
                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Đã thêm thành công vào cơ sỡ dữ liệu.");
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    /*rtxt_BuaSang.Text = "";*/ rtxt_BuaSang.Enabled = false;
                    /*rtxt_BuaTrua.Text = string.Empty;*/ rtxt_BuaTrua.Enabled = false;
                    /*rtxt_BuaChieu.Text = string.Empty;*/ rtxt_BuaChieu.Enabled = false;
                    /*txt_CpSang.Text = string.Empty;*/ txt_CpSang.Enabled = false;
                    /*txt_CpTrua.Text = string.Empty;*/ txt_CpTrua.Enabled = false;
                    /*txt_CpChieu.Text = string.Empty;*/ txt_CpChieu.Enabled = false;
                    //txt_TongChiPhi.Text = "0";
                    //cbb_TenLop.SelectedValue = -1;
                    //dtp_NgayThangNam.Value = DateTime.Today;
                    //bt_Them.Text = "Thêm";
                    bt_Them.Enabled = false;
                    bt_Xoa.Enabled = true;
                    bt_Sua.Enabled = true;
                }
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {

                if (MessageBox.Show("Bạn có thực sự muốn xóa thực đơn của lớp " + cbb_TenLop.Text + " vào ngày " + dtp_NgayThangNam.Text + ".", "Thông báo"
                                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM BuaAn WHERE MaLop = '" + cbb_TenLop.SelectedValue + "' AND NgayThangNam='" + dtp_NgayThangNam.Text + "'", con);
                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Đã xóa thành công.");
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    rtxt_BuaSang.Text = ""; rtxt_BuaSang.Enabled = true;
                    rtxt_BuaTrua.Text = string.Empty; rtxt_BuaTrua.Enabled = true;
                    rtxt_BuaChieu.Text = string.Empty; rtxt_BuaChieu.Enabled = true;
                    txt_CpSang.Text = string.Empty; txt_CpSang.Enabled = true;
                    txt_CpTrua.Text = string.Empty; txt_CpTrua.Enabled = true;
                    txt_CpChieu.Text = string.Empty; txt_CpChieu.Enabled = true;
                    txt_TongChiPhi.Text = "0";
                    bt_Them.Enabled = true;
                    bt_Xoa.Enabled = false;
                    bt_Sua.Enabled = false;
                }
            }
        }

        private void frm_BuaAn_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void grp_TTBA_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.DodgerBlue, ButtonBorderStyle.Solid);
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                if (bt_Sua.Text == "Sửa")
                {
                    bt_Them.Enabled = false;
                    bt_Xoa.Enabled = false;
                    rtxt_BuaSang.Enabled = true;
                    rtxt_BuaTrua.Enabled = true;
                    rtxt_BuaChieu.Enabled = true;
                    txt_CpSang.Enabled = true;
                    txt_CpTrua.Enabled = true;
                    txt_CpChieu.Enabled = true;
                    bt_Sua.Text = "Lưu";
                }
                else if (bt_Sua.Text == "Lưu")
                {
                    if (MessageBox.Show("Bạn có chắc chắn thay đổi nội dung thực đơn của lớp " + cbb_TenLop.Text + " vào ngày " + dtp_NgayThangNam.Text + " .", "Thông báo"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        try
                        {
                            if (con.State == ConnectionState.Closed)
                                con.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE BuaAn SET BuaSang = N'" + rtxt_BuaSang.Text + "', BuaTrua = N'" + rtxt_BuaTrua.Text + "', BuaChieu = N'" + rtxt_BuaChieu.Text + "', CpBuaSang = '" + int.Parse(txt_CpSang.Text) + "', CpBuaTrua = '" + int.Parse(txt_CpTrua.Text) + "', CpBuaChieu = '" + int.Parse(txt_CpChieu.Text) + "', TongCp = '" + int.Parse(txt_TongChiPhi.Text) + "'", con);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Thay đổi thực đơn ngày " + dtp_NgayThangNam.Text + " của lớp " + cbb_TenLop.Text + " thành công.", "Thông báo");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        bt_Xoa.Enabled = true;
                        rtxt_BuaSang.Enabled = false;
                        rtxt_BuaTrua.Enabled = false;
                        rtxt_BuaChieu.Enabled = false;
                        txt_CpSang.Enabled = false;
                        txt_CpTrua.Enabled = false;
                        txt_CpChieu.Enabled = false;
                        bt_Sua.Text = "Sửa";
                    }
                    else
                    {
                        bt_Xoa.Enabled = true;
                        rtxt_BuaSang.Enabled = false;
                        rtxt_BuaTrua.Enabled = false;
                        rtxt_BuaChieu.Enabled = false;
                        txt_CpSang.Enabled = false;
                        txt_CpTrua.Enabled = false;
                        txt_CpChieu.Enabled = false;
                        bt_Sua.Text = "Sửa";
                    }
                }
            }
        }

        private void dtp_NgayThangNam_ValueChanged(object sender, EventArgs e)
        {
            if (cbb_TenLop.SelectedValue != null)
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM BuaAn WHERE MaLop = '" + cbb_TenLop.SelectedValue + "' AND NgayThangNam = '" + dtp_NgayThangNam.Value.ToString("dd/MM/yyyy") + "'", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        rtxt_BuaSang.Enabled = false;
                        rtxt_BuaTrua.Enabled = false;
                        rtxt_BuaChieu.Enabled = false;
                        txt_CpSang.Enabled = false;
                        txt_CpTrua.Enabled = false;
                        txt_CpChieu.Enabled = false;
                        txt_TongChiPhi.Enabled = false;
                        rtxt_BuaSang.Text = sdr["BuaSang"].ToString();
                        txt_CpSang.Text = sdr["CpBuaSang"].ToString();
                        rtxt_BuaTrua.Text = sdr["BuaTrua"].ToString();
                        txt_CpTrua.Text = sdr["CpBuaTrua"].ToString();
                        rtxt_BuaChieu.Text = sdr["BuaChieu"].ToString();
                        txt_CpChieu.Text = sdr["CpBuaChieu"].ToString();
                        txt_TongChiPhi.Text = sdr["TongCp"].ToString();
                        bt_Them.Enabled = false;
                        bt_Xoa.Enabled = true;
                        bt_Sua.Enabled = true;
                    }
                    else
                    {
                        rtxt_BuaSang.Enabled = true; rtxt_BuaSang.Text = string.Empty;
                        rtxt_BuaTrua.Enabled = true; rtxt_BuaTrua.Text = string.Empty;
                        rtxt_BuaChieu.Enabled = true; rtxt_BuaChieu.Text = string.Empty;
                        txt_CpSang.Enabled = true; txt_CpSang.Text = string.Empty;
                        txt_CpTrua.Enabled = true; txt_CpTrua.Text = string.Empty;
                        txt_CpChieu.Enabled = true; txt_CpChieu.Text = string.Empty;
                        bt_Them.Enabled = true;
                        bt_Xoa.Enabled = false;
                        bt_Sua.Enabled = false; bt_Sua.Text = "Sửa";
                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Report_BuaAn frm = new frm_Report_BuaAn();
            frm.Show();
        }
    }
}
