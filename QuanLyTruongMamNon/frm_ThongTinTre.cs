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
using System.Data.Sql;
using System.Drawing.Drawing2D;
using System.IO;
using System.Globalization;

namespace QuanLyTruongMamNon
{
    public partial class frm_ThongTinTre : Form
    {
        public frm_ThongTinTre()
        {
            InitializeComponent();
            setDataGridView_EditTable(false);
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True");
        //Data Source=(LocalDB)\v11.0;AttachDbFilename="C:\Users\Lucis Noctis\Desktop\QuanLyTruongMamNon\QuanLyTruongMamNon\CoSoDuLieu.mdf";Integrated Security=True
        //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lucis Noctis\Desktop\QuanLyTruongMamNon\QuanLyTruongMamNon\CoSoDuLieu.mdf;Integrated Security=True"
        SqlCommand cmd;
        private bool _vt;
        public bool vt
        {
            get { return _vt; }
            set { _vt = value; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CapNhat();
            LopHoc();
            LoadDataInto_ComboBox_KhoiHoc();
            LoadDataInto_ComboBox_LopHoc();
            LoadDataInto_ComboBox_Thang_Nam();
        }
        private void paint_ListView(ListView lst_TTTK)
        {
            for (int i = 0; i < lst_TTTK.Items.Count; i++)
            {
                if (lst_TTTK.Items[i].Index % 2 == 0)
                {
                    lst_TTTK.Items[i].BackColor = Color.LightGreen;
                }
            }
        }
        private void clearGroupbox(GroupBox grp)
        {
            foreach (Control ctr in grp.Controls)
            {
                if (ctr.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)ctr;
                    t.Clear();
                }
                else if (ctr.GetType() == typeof(DateTimePicker))
                {
                    DateTimePicker t = (DateTimePicker)ctr;
                    t.Value = DateTime.Today;
                }
            }
        }
        private void CapNhat()
        {
            bt_Xoa.Enabled = false;
            bt_CapNhat.Enabled = false;
            SqlDataReader dr;
            con.Open();
            string cmdString = "SELECT  TenLop, TenKhoi FROM  LopHoc, KhoiHoc WHERE LopHoc.MaKhoi = KhoiHoc.MaKhoi";
            cmd = new SqlCommand(cmdString, con);
            TreeView_DSLH.Nodes.Clear();
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (TreeView_DSLH.Nodes.ContainsKey(dr["TenKhoi"].ToString()))
                    {
                        TreeView_DSLH.Nodes[dr["TenKhoi"].ToString()].Nodes.Add(dr["TenLop"].ToString());
                    }
                    else if (!TreeView_DSLH.Nodes.ContainsKey(dr["TenKhoi"].ToString()))
                    {
                        TreeNode node = new TreeNode(dr["TenKhoi"].ToString());
                        node.Name = dr["TenKhoi"].ToString();
                        TreeView_DSLH.Nodes.Add(node);
                        TreeView_DSLH.Nodes[dr["TenKhoi"].ToString()].Nodes.Add(dr["TenLop"].ToString());
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }

            con.Open();
            cmdString = "SELECT TenLop, TenTre, TenKhoi FROM HocSinh, LopHoc, KhoiHoc WHERE LopHoc.MaLop = HocSinh.MaLop AND LopHoc.MaKhoi=KhoiHoc.MaKhoi";
            cmd = new SqlCommand(cmdString, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string tenkhoi = rd["TenKhoi"].ToString();
                    string tenlop = rd["TenLop"].ToString();
                    string tentre = rd["TenTre"].ToString();
                    for (int i = 0; i < TreeView_DSLH.Nodes.Count; i++)
                    {
                        if (TreeView_DSLH.Nodes[i].Text == tenkhoi)
                        {
                            for (int j = 0; j < TreeView_DSLH.Nodes[i].Nodes.Count; j++)
                            {
                                if (TreeView_DSLH.Nodes[i].Nodes[j].Text == tenlop)
                                {
                                    TreeView_DSLH.Nodes[i].Nodes[j].Nodes.Add(tentre);
                                }
                            }
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
        }
        private void clear(GroupBox grp)
        {
            foreach (Control ctr in grp.Controls)
            {
                if (ctr.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)ctr;
                    t.Clear();
                }
                else if (ctr.GetType() == typeof(MaskedTextBox))
                {
                    MaskedTextBox t = (MaskedTextBox)ctr;
                    t.Clear();
                }
                else if (ctr.GetType() == typeof(RadioButton))
                {
                    RadioButton t = (RadioButton)ctr;
                    t.Checked = false;
                }
            }
        }

        //Tab thong tin tre
        private string GioiTinh(RadioButton rdb)
        {
            if (rdb_Nam.Checked == true)
                return "Nam";
            return "Nữ";
        }
        byte[] img;
        private void TreeView_DSLH_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool kt = true;
            string indexLop = null;
            int indexTre = -1;
            for (int i = 0; i < TreeView_DSLH.Nodes.Count && kt; i++)
            {
                for (int j = 0; j < TreeView_DSLH.Nodes[i].Nodes.Count && kt; j++)
                {
                    for (int k = 0; k < TreeView_DSLH.Nodes[i].Nodes[j].Nodes.Count && kt; k++)
                    {
                        if (TreeView_DSLH.Nodes[i].Nodes[j].Nodes[k].Text == e.Node.Text)
                        {
                            indexLop = TreeView_DSLH.Nodes[i].Nodes[j].Text;
                            indexTre = e.Node.Index;
                            kt = false;
                            break;
                        }
                    }
                }
            }
            if (indexLop != null)
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM HocSinh, LopHoc WHERE HocSinh.MaLop=LopHoc.MaLop AND TenLop = @TenLop", con);
                cmd.Parameters.AddWithValue("@TenLop", indexLop);
                //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM HocSinh, LopHoc WHERE HocSinh.MaLop=LopHoc.MaLop AND TenLop='" + indexLop + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                //sda.Fill(tb);
                tb.Load(dr);
                txt_HoTen.Text = tb.Rows[indexTre]["TenTre"].ToString();
                txt_Ma.Text = tb.Rows[indexTre]["MaTre"].ToString();
                txt_NgayThangNam.Value = DateTime.ParseExact(tb.Rows[indexTre]["NgaySinh"].ToString(), "dd/MM/yyyy", null);
                txt_NgayNhapHoc.Text = tb.Rows[indexTre]["NgayNhapHoc"].ToString();
                txt_DiaChi.Text = tb.Rows[indexTre]["DiaChi"].ToString();
                txt_LopHienTai.Text = tb.Rows[indexTre]["TenLop"].ToString();
                txt_MaLop.Text = tb.Rows[indexTre]["MaLop"].ToString();
                if (tb.Rows[indexTre]["GioiTinh"].ToString().Contains("Nam"))
                {
                    rdb_Nam.Checked = true;
                    rdb_Nu.Checked = false;
                }
                else
                {
                    rdb_Nu.Checked = true;
                    rdb_Nam.Checked = false;
                }

                img = (byte[])(tb.Rows[indexTre]["Hinh"]);
                if(img == null)
                {
                    imgBox = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    imgBox.Image = Image.FromStream(ms);
                }

                con.Close();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM PhuHuynh WHERE MaTre = '" + int.Parse(txt_Ma.Text) + "'", con);
                con.Open();
                SqlDataReader dre = cmd1.ExecuteReader();
                if (dre.Read())
                {
                    txt_HoTenCha.Text = dre["HoTenCha"].ToString();
                    txt_NgheNghiepCha.Text = dre["NgheNghiepCha"].ToString();
                    txt_SDTCha.Text = dre["SDTCha"].ToString();
                    txt_HoTenMe.Text = dre["HoTenMe"].ToString();
                    txt_NgheNghiepMe.Text = dre["NgheNghiepMe"].ToString();
                    txt_SDTMe.Text = dre["SDTMe"].ToString();
                }
                con.Close();
                bt_Xoa.Enabled = true;
                bt_CapNhat.Enabled = true;
            }
        }
        string imgLoc = "";
        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                frm_ThemHocSinh form = new frm_ThemHocSinh();
                form.vt = _vt;
                form.Show();
                Refresh();
            }
        }
        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn thay đổi thông tin của trẻ này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    try
                    {
                        //byte[] img = null;
                        if (imgLoc != "")
                        {
                            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            img = br.ReadBytes((int)fs.Length);
                        }


                        con.Open();
                        cmd = new SqlCommand("UPDATE HocSinh SET TenTre = @TenTre, NgaySinh = @NgaySinh, DiaChi = @DiaChi, GioiTinh = @GioiTinh, Hinh = @Hinh WHERE MaTre='" + txt_Ma.Text + "'", con);
                        cmd.Parameters.Add("@TenTre", txt_HoTen.Text);
                        cmd.Parameters.Add("@NgaySinh", txt_NgayThangNam.Text);
                        cmd.Parameters.Add("@DiaChi", txt_DiaChi.Text);
                        cmd.Parameters.Add("@GioiTinh", GioiTinh(rdb_Nam));
                        cmd.Parameters.Add("@Hinh", img);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        cmd = new SqlCommand("UPDATE PhuHuynh SET HoTenCha = @HoTenCha, NgheNghiepCha = @NgheNghiepCha, SDTCHa = @SDTCha, HoTenMe = @HoTenMe, NgheNghiepMe = @NgheNghiepMe, SDTMe = @SDTMe WHERE MaTre='" + txt_Ma.Text + "'", con);
                        cmd.Parameters.Add("@HoTenCha", txt_HoTenCha.Text);
                        cmd.Parameters.Add("@NgheNghiepCha", txt_NgheNghiepCha.Text);
                        cmd.Parameters.Add("@SDTCha", txt_SDTCha.Text);
                        cmd.Parameters.Add("@HoTenMe", txt_HoTenMe.Text);
                        cmd.Parameters.Add("@NgheNghiepMe", txt_NgheNghiepMe.Text);
                        cmd.Parameters.Add("@SDTMe", txt_SDTMe.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thông tin đã được thay đổi thành công.");
                        con.Close();

                        CapNhat();
                        clearGroupbox(grp_TTHS);
                        clearGroupbox(grp_TTPH);
                        imgBox.ImageLocation = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa trẻ này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("DELETE FROM PhuHuynh WHERE MaTre='" + txt_Ma.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        cmd = new SqlCommand("DELETE FROM HocPhi WHERE MaTre = '" + txt_Ma.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        cmd = new SqlCommand("DELETE FROM HocSinh WHERE MaTre='" + txt_Ma.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        CapNhat();
                        clearGroupbox(grp_TTHS);
                        clearGroupbox(grp_TTPH);
                        imgBox.Image = null;
                        MessageBox.Show("Đã xóa thành công khỏi cơ sở dữ liệu.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
        }

        //Tab xep lop - len lop

        private void LopHoc()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT TenLop FROM LopHoc", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbb_LopHienTai.Items.Add(dr[0]);
                    cbb_LopMoi.Items.Add(dr[0]);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }
        private string MaLop(ComboBox cbb)
        {
            string s = null;
            con.Open();
            cmd = new SqlCommand("SELECT MaLop FROM LopHoc where TenLop = N'" + cbb.Text + "'", con);
            //cmd.Parameters.AddWithValue("@TenLop", cbb_LopMoi.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                s = dr["MaLop"].ToString();
            }
            con.Close();
            return s;
        }
        private void cbb_LopHienTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_LopHienTai.Items.Clear();
            grp_LopHienTai.Text = "Danh sách lớp " + cbb_LopHienTai.Text;
            grp_LopHienTai.ForeColor = Color.Blue;
            con.Open();
            cmd = new SqlCommand("SELECT MaTre, TenTre, NgaySinh, GioiTinh, NgayNhapHoc, HocSinh.MaLop FROM HocSinh, LopHoc WHERE HocSinh.MaLop = LopHoc.MaLop AND TenLop=N'" + cbb_LopHienTai.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                //DateTime ngsinh = DateTime.ParseExact(dr[2].ToString(), "dd/MM/yyyy", null);
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(dr[5].ToString());
                lst_LopHienTai.Items.Add(item);
            }
            con.Close();
            paint_ListView(lst_LopHienTai);
        }
        private void cbb_LopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_LopMoi.Items.Clear();
            grp_LopMoi.Text = "Danh sách lớp " + cbb_LopMoi.Text;
            grp_LopMoi.ForeColor = Color.Blue;
            con.Open();
            cmd = new SqlCommand("SELECT MaTre, TenTre, NgaySinh, GioiTinh, NgayNhapHoc, HocSinh.MaLop FROM HocSinh, LopHoc WHERE HocSinh.MaLop = LopHoc.MaLop AND TenLop=N'" + cbb_LopMoi.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                //DateTime ngsinh = DateTime.ParseExact(dr[2].ToString(), "dd/MM/yyyy", null);
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(dr[5].ToString());
                lst_LopMoi.Items.Add(item);
            }
            con.Close();
            paint_ListView(lst_LopMoi);
        }
        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                if (lst_LopMoi.Items.Count > 0)
                {
                    try
                    {
                        string malop1 = MaLop(cbb_LopHienTai);
                        string malop2 = MaLop(cbb_LopMoi);
                        con.Open();
                        foreach (ListViewItem item in lst_LopMoi.Items)
                        {
                            if (item.SubItems[5].Text == malop1)
                            {
                                cmd = new SqlCommand("UPDATE HocSinh SET MaLop = '" + malop2 + "' WHERE MaTre='" + int.Parse(item.SubItems[0].Text) + "'", con);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }

                if (lst_LopHienTai.Items.Count > 0)
                {
                    try
                    {
                        string malop1 = MaLop(cbb_LopHienTai);
                        string malop2 = MaLop(cbb_LopMoi);
                        con.Open();
                        foreach (ListViewItem item in lst_LopHienTai.Items)
                        {
                            if (item.SubItems[5].Text == malop2)
                            {
                                cmd = new SqlCommand("UPDATE HocSinh SET MaLop = '" + malop1 + "' WHERE MaTre='" + int.Parse(item.SubItems[0].Text) + "'", con);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
                MessageBox.Show("Hoàn tất việc xếp lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bt_Down_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lst_LopHienTai.SelectedItems)
            {
                lst_LopHienTai.Items.Remove(item);
                lst_LopMoi.Items.Add(item);
            }
            paint_ListView(lst_LopHienTai);
            paint_ListView(lst_LopMoi);
        }

        private void bt_Up_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lst_LopMoi.SelectedItems)
            {
                lst_LopMoi.Items.Remove(item);
                lst_LopHienTai.Items.Add(item);
            }
            paint_ListView(lst_LopHienTai);
            paint_ListView(lst_LopMoi);
        }

        private void bt_DownAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lst_LopHienTai.Items)
            {
                lst_LopHienTai.Items.Remove(item);
                lst_LopMoi.Items.Add(item);
            }
            paint_ListView(lst_LopHienTai);
            paint_ListView(lst_LopMoi);
        }

        private void bt_UpAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lst_LopMoi.Items)
            {
                lst_LopMoi.Items.Remove(item);
                lst_LopHienTai.Items.Add(item);
            }
            paint_ListView(lst_LopHienTai);
            paint_ListView(lst_LopMoi);
        }

        private void tab_ThongTinTre_TabIndexChanged(object sender, EventArgs e)
        {
            if (tab_ThongTinTre.SelectedIndex == 0)
            {
                CapNhat();
            }
            else
                LopHoc();
        }

        private void tab_ThongTinTre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_ThongTinTre.SelectedIndex == 0)
            {
                CapNhat();
            }
            else
            {
                lst_LopHienTai.Items.Clear();
                lst_LopMoi.Items.Clear();
                cbb_LopHienTai.Items.Clear();
                cbb_LopMoi.Items.Clear();
                LopHoc();
            }
        }

        private void lst_LopHienTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_LopHienTai.SelectedItems.Count > 0)
                bt_Down.Enabled = true;
            else
                bt_Down.Enabled = false;

        }

        private void lst_LopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_LopMoi.SelectedItems.Count > 0)
                bt_Up.Enabled = true;
            else
                bt_Up.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.OrangeRed, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void frm_ThongTinTre_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Blue, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhat();
            clear(grp_DSLH);
            clear(grp_TTHS);
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

        //Tab học phi
        private void LoadDataInto_ComboBox_KhoiHoc()
        {
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM KhoiHoc", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //cbb_KhoiHoc.DataSource = dt;
            //cbb_KhoiHoc.DisplayMember = "TenKhoi";
            //cbb_KhoiHoc.ValueMember = "MaKhoi";
            //cbb_KhoiHoc.SelectedValue = -1;
        }

        private void LoadDataInto_ComboBox_LopHoc()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM LopHoc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbb_LopHoc.DataSource = dt;
            cbb_LopHoc.DisplayMember = "TenLop";
            cbb_LopHoc.ValueMember = "MaLop";
            cbb_LopHoc.SelectedValue = -1;
        }

        private void LoadDataInto_ComboBox_Thang_Nam()
        {
            for (int i = 1; i < 13; i++)
                cbb_Thang.Items.Add(i.ToString());
            int currentyear = DateTime.Today.Year;
            for (int i = currentyear - 10; i <= currentyear + 10; i++)
                cbb_Nam.Items.Add(i.ToString());
        }
        private void LoadDataInto_DataGridView_HocPhi()
        {
            string s = "SELECT HocSinh.MaTre, TenTre, TenLop, ThangNam, SoTien, TinhTrang, NgayThu FROM HocSinh, LopHoc, HocPhi WHERE HocSinh.MaTre = HocPhi.MaTre AND HocSinh.MaLop = LopHoc.MaLop AND LopHoc.MaLop = '" + cbb_LopHoc.SelectedValue + "' AND ThangNam = '" + cbb_Thang.Text + "/" + cbb_Nam.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgV_HocPhi.DataSource = dt;
            if (dgV_HocPhi.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgV_HocPhi.Rows)
                {
                    if (row.Cells["col_TinhTrang"].Value.ToString() == "Chưa đóng")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                foreach (DataGridViewRow row in dgV_HocPhi.Rows)
                {
                    if(row.Cells["col_TinhTrang"].Value.ToString() != "Chưa đóng")
                    {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["col_checkHP"];
                        cell.Value = 1;
                    }
                }
            }
        }

        private void dtp_Thang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_HienThi_Click(object sender, EventArgs e)
        {
            if (cbb_LopHoc.Text == string.Empty || cbb_Thang.Text == string.Empty || cbb_Nam.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn đầy đủ thông tin");
            }
            else
            {
                string ThangNam = cbb_Thang.Text + "/" + cbb_Nam.Text;
                try
                {
                    bool k = false;
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ThangNam FROM HocPhi WHERE ThangNam = '" + ThangNam + "'", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        k = true;
                    }
                    DataTable dt = new DataTable();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    if (k == false)
                    {
                        if (MessageBox.Show("Danh sách học phí tháng " + ThangNam + " chưa được khởi tạo. Bạn có muốn khởi tạo ngay?", "Thông báo"
                            , MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("SELECT MaTre FROM HocSinh", con);
                            sda.Fill(dt);

                            if (con.State == ConnectionState.Closed)
                                con.Open();
                            SqlCommand cmd1;
                            foreach (DataRow row in dt.Rows)
                            {
                                cmd1 = new SqlCommand("INSERT INTO HocPhi(MaTre, ThangNam, TinhTrang) VALUES('" + int.Parse(row["MaTre"].ToString()) + "', '" + ThangNam + "', N'Chưa đóng')", con);
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Khởi tạo danh sách học phí thành công.");
                                k = true;
                            }
                            if (con.State == ConnectionState.Open)
                                con.Close();
                        }
                    }
                    else if (k == true)
                    {
                        LoadDataInto_DataGridView_HocPhi();
                        if (dgV_HocPhi.Rows.Count > 0)
                        {
                            txt_SoTien.Enabled = true;
                            bt_SetHP.Enabled = true;
                            ck_CapNhat.Enabled = true;
                        }
                        //dgV_HocPhi.Columns["HocPhi"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void bt_SetHP_Click(object sender, EventArgs e)
        {
            if (dgV_HocPhi.Rows.Count > 0)
            {
                int row = dgV_HocPhi.Rows.Count;
                decimal hocphi = decimal.Parse(txt_SoTien.Text);
                for (int i = 0; i < row; i++)
                    dgV_HocPhi[5, i].Value = hocphi;
            }
        }

        private void setDataGridView_EditTable(bool k)
        {
            dgV_HocPhi.ReadOnly = !k;
            dgV_HocPhi.Columns["col_checkHP"].Visible = k;
            dgV_HocPhi.Columns["col_TinhTrang"].Visible = !k;

        }

        private void ck_CapNhat_CheckedChanged(object sender, EventArgs e)
        {
            setDataGridView_EditTable(ck_CapNhat.Checked);
        }

        private void dgV_HocPhi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgV_HocPhi.Columns[e.ColumnIndex].Name == "col_checkHP" && dgV_HocPhi.CurrentCell is DataGridViewCheckBoxCell)
            {
                bool isChecked = (bool)dgV_HocPhi[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                if (isChecked == true)
                {
                    dgV_HocPhi.Rows[e.RowIndex].Cells["col_TinhTrang"].Value = "Đã thu";
                    dgV_HocPhi.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    foreach (DataGridViewColumn col in dgV_HocPhi.Columns)
                    {
                        if (col.Name != "col_checkHP")
                            col.ReadOnly = true;
                    }
                    dgV_HocPhi.Rows[e.RowIndex].Cells["col_TinhTrang"].Value = "Chưa đóng";
                    dgV_HocPhi.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    //dtp.Visible = false;
                    dgV_HocPhi.Rows[e.RowIndex].Cells["col_NgayThu"].Value = string.Empty;
                    
                }
                dgV_HocPhi.EndEdit();
            }
        }

        private void dgV_HocPhi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgV_HocPhi.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgV_HocPhi_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgV_HocPhi.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgV_HocPhi.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        DateTimePicker dtp;
        private void dgV_HocPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                dtp = new DateTimePicker();
                if (dgV_HocPhi.CurrentRow.Cells["col_TinhTrang"].Value.ToString() != "Chưa đóng")
                {
                    
                    dgV_HocPhi.Controls.Add(dtp);
                    dtp.Format = DateTimePickerFormat.Custom;
                    dtp.CustomFormat = "dd/MM/yyyy";
                    Rectangle Rectangle = dgV_HocPhi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(Rectangle.Width, Rectangle.Height);
                    dtp.Location = new Point(Rectangle.X, Rectangle.Y);
                    dtp.Visible = true;
                    dtp.CloseUp += new EventHandler(dtp_CloseUp);
                    dtp.TextChanged += new EventHandler(dtp_OnTextChange);
                    dtp.DropDown += new EventHandler(dtp_DropDown);
                    dtp.ValueChanged += new EventHandler(dtp_ValueChanged);
                    
                }
                else
                {
                    dgV_HocPhi.CurrentRow.Cells["col_NgayThu"].Value = "";
                    dtp.Visible = false;
                }
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
           var timepicker = sender as DateTimePicker;
           timepicker.Value = new DateTime(timepicker.Value.Year, timepicker.Value.Month, timepicker.Value.Day);
        }
        int oldday;
        private void dtp_DropDown(object sender, EventArgs e)
        {
            oldday = ((DateTimePicker)(sender)).Value.Day;
        }
       // private void dtp_DropDown(object sender )

        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            //dgV_HocPhi.CurrentCell.Value = dtp.Text.ToString();
            dtp.Visible = false;
        }

        private void dtp_CloseUp(object sender, EventArgs e)
        {
           //dtp.Value.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
           dtp.Value.GetDateTimeFormats();
           dgV_HocPhi.CurrentCell.Value = dtp.Value.Date;
    
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            string NgayThu = cbb_Thang.Text + "/" + cbb_Nam.Text;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd;
                foreach (DataGridViewRow row in dgV_HocPhi.Rows)
                {
                    cmd = new SqlCommand("UPDATE HocPhi SET SoTien = '" + decimal.Parse(row.Cells["col_HocPhi"].Value.ToString()) + "', TinhTrang = N'" + row.Cells["col_TinhTrang"].Value + "', NgayThu = '" + row.Cells["col_NgayThu"].Value.ToString() + "' WHERE MaTre = '"+int.Parse(row.Cells["col_MaTre"].Value.ToString())+"' AND ThangNam = '"+NgayThu+"'", con);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật thành công vào cơ sở dữ liệu.");
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            open.Title = "Chọn ảnh đại diện";
            if(open.ShowDialog() == DialogResult.OK)
            {
                imgLoc = open.FileName.ToString();
                imgBox.ImageLocation = imgLoc;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Report_HocPhi frm = new frm_Report_HocPhi();
            frm.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
    }
}
