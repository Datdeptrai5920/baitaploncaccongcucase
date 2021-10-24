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
    public partial class frm_ThemGiaoVien_update_ : Form
    {
        public frm_ThemGiaoVien_update_()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True");
        SqlCommand cmd;
        private bool _vt;
        public bool vt
        {
            get { return _vt; }
            set { _vt = value; }
        }
        private void tSb_Them_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                if (tab_GiaoVien.TabCount == 1)
                {
                    frm_ThemGiaoVien frm = new frm_ThemGiaoVien();
                    frm.vt = _vt;
                    MyTabPage tb = new MyTabPage(frm);
                    tab_GiaoVien.TabPages.Add(tb);
                    tab_GiaoVien.SelectTab(tab_GiaoVien.TabCount - 1);
                }
                clear(grp_TTHS);
            }
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
                if (ctr.GetType() == typeof(RadioButton))
                {
                    RadioButton t = (RadioButton)ctr;
                    t.Checked = false;
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

        private void CapNhat()
        {
            imgBox.ImageLocation = "";
            tSb_Sua.Enabled = false;
            tSb_Xoa.Enabled = false;
            SqlDataReader dr;
            con.Open();
            string cmdString = "SELECT  TenKhoi FROM KhoiHoc";
            cmd = new SqlCommand(cmdString, con);
            TreeView_DSGV.Nodes.Clear();
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TreeNode node = new TreeNode(dr["TenKhoi"].ToString());
                    node.Name = dr["TenKhoi"].ToString();
                    TreeView_DSGV.Nodes.Add(node);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }

            con.Open();
            cmdString = "SELECT TenLop, TenGV, TenKhoi FROM GiaoVien, LopHoc, KhoiHoc WHERE LopHoc.MaLop = GiaoVien.MaLop AND LopHoc.MaKhoi=KhoiHoc.MaKhoi";
            cmd = new SqlCommand(cmdString, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string tenkhoi = rd["TenKhoi"].ToString();
                    string tengv = rd["TenGV"].ToString();
                    //if (TreeView_DSLH.Nodes[dr["TenKhoi"].ToString()].Nodes.ContainsKey(dr["TenLop"].ToString()))
                    //{
                    //TreeNode node = new TreeNode(rd["TenTre"].ToString());
                    //node.Name = rd["TenTre"].ToString();

                    //TreeView_DSLH.Nodes[tenkhoi].Nodes[tenlop].Nodes.Add(new TreeNode(tentre));
                    //TreeView_DSLH.Nodes[0].Nodes[0].Nodes.Add(rd["TenTre"].ToString());
                    for (int i = 0; i < TreeView_DSGV.Nodes.Count; i++)
                    {
                        if (TreeView_DSGV.Nodes[i].Text == tenkhoi)
                        {
                            //if (tengv != "Lê Minh" && tengv != "Đỗ Thy")
                            {
                                TreeView_DSGV.Nodes[i].Nodes.Add(tengv);
                            }
                        }
                    }
                    //foreach(TreeNode pNode in TreeView_DSLH.Nodes)
                    //{
                    //    if(pNode.Text == tenkhoi)
                    //    {
                    //        foreach(TreeNode cNode in TreeView_DSLH.Nodes[pNode.Text].Nodes)
                    //        {
                    //            if (cNode.Text == tenlop)
                    //                TreeView_DSLH.Nodes[pNode.Text].Nodes[cNode.Text].Nodes.Add(tentre);
                    //        }
                    //    }
                    //}
                    //}

                    //TreeView_DSLH.Nodes[0].Nodes[0].Nodes.Add(dr["TenTre"].ToString());

                    //}
                    //else if (!TreeView_DSLH.Nodes.ContainsKey(dr["TenKhoi"].ToString()))
                    //{
                    //    TreeNode node = new TreeNode(dr["TenKhoi"].ToString());
                    //    node.Name = dr["TenKhoi"].ToString();
                    //    TreeView_DSLH.Nodes.Add(node);
                    //    TreeView_DSLH.Nodes[dr["TenKhoi"].ToString()].Nodes.Add(dr["TenLop"].ToString());
                    //}       
                    //TreeNode node1 = new TreeNode(dr["TenLop"].ToString());
                    //node1.Name = dr["TenLop"].ToString();
                    //TreeView_DSLH.Nodes[dr["TenKhoi"].ToString()].Nodes[dr["TenLop"].ToString()].Nodes.Add(node1);
                    //TreeView_DSLH.Nodes.Add("ParentKey1", "Parent-1  Text");
                    //TreeView_DSLH.Nodes["ParentKey1"].Nodes.Add("Child-1 Text");
                    //TreeView_DSLH.Nodes["ParentKey1"].Nodes.Add("ChildKey2", "Child-2 Text");
                    //TreeView_DSLH.Nodes["ParentKey1"].Nodes["ChildKey2"].Nodes.Add(tentre);
                }

                con.Close();
                imgBox.ImageLocation = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
        }

        private void frm_ThemGiaoVien_update__Load(object sender, EventArgs e)
        {
            tabPage_ThongTin.BackColor = Color.Transparent;
            CapNhat();
            //cbb_TrinhDo.Items.AddRange(new object[] { "Đại học", "Cao đẳng", "Trung cấp chuyên nghiệp" });
        }

        DateTime t;
        byte[] img;
        private void TreeView_DSGV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool kt = true;
            string khoihoc = null;
            int indexgv = -1;
            for (int i = 0; i < TreeView_DSGV.Nodes.Count && kt; i++)
            {
                for (int j = 0; j < TreeView_DSGV.Nodes[i].Nodes.Count && kt; j++)
                {
                    if (TreeView_DSGV.Nodes[i].Nodes[j].Text == e.Node.Text)
                    {
                        khoihoc = TreeView_DSGV.Nodes[i].Text;
                        //if (TreeView_DSGV.Nodes[i].Text == "Chồi 1")
                        //    indexgv = e.Node.Index + 2;
                        //else
                            indexgv = e.Node.Index;
                        kt = false;
                        break;
                    }
                    else
                        clear(grp_TTHS);
                }
            }
            if (khoihoc != null)
            {
                tSb_Xoa.Enabled = true;
                tSb_Sua.Enabled = true;
                con.Open();
                cmd = new SqlCommand("SELECT * FROM GiaoVien, LopHoc, KhoiHoc WHERE GiaoVien.MaLop=LopHoc.MaLop AND LopHoc.MaKhoi = KhoiHoc.MaKhoi AND TenKhoi = @TenKhoi", con);
                cmd.Parameters.AddWithValue("@TenKhoi", khoihoc);
                //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM HocSinh, LopHoc WHERE HocSinh.MaLop=LopHoc.MaLop AND TenLop='" + indexLop + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                //sda.Fill(tb);
                tb.Load(dr);
                //while(dr.Read())
                //{
                //    textBox1.Text = tb.Rows[indexLop]["TenTre"].ToString();
                //    textBox1.Text = dr["TenTre"].ToString();
                //    textBox6.Text = dr["MaTre"].ToString();
                //    textBox2.Text = dr["NgaySinh"].ToString();
                //    textBox5.Text = dr["NgayNhapHoc"].ToString();
                //    textBox3.Text = dr["DiaChi"].ToString();
                //    textBox4.Text = dr["TenLop"].ToString();
                //    textBox7.Text = dr["MaLop"].ToString();
                //}
                //for (int i = 0; i < tb.Rows.Count;i++)
                //{
                //if (indexTre!=-1)
                //{
                //if (tb.Rows[indexgv]["MaGV"].ToString() != "GV01" || tb.Rows[indexgv]["MaGV"].ToString() != "GV02")
                {
                    txt_HoTen.Text = tb.Rows[indexgv]["TenGV"].ToString();
                    txt_Ma.Text = tb.Rows[indexgv]["MaGV"].ToString();
                    txt_NgayThangNam.Value = DateTime.ParseExact(tb.Rows[indexgv]["NgaySinh"].ToString(), "dd/MM/yyyy", null);
                    dtp_NgayVaoLam.Value = DateTime.ParseExact(tb.Rows[indexgv]["NgayBatDau"].ToString(), "dd/MM/yyyy", null);
                    txt_DiaChi.Text = tb.Rows[indexgv]["DiaChi"].ToString();
                    txt_CMND.Text = tb.Rows[indexgv]["CMND"].ToString();
                    txt_SDT.Text = tb.Rows[indexgv]["SDT"].ToString();
                    cbb_TrinhDo.Text = tb.Rows[indexgv]["TrinhDo"].ToString();
                    txt_HSL.Text = tb.Rows[indexgv]["HSL"].ToString();
                    txt_LuongCB.Text = tb.Rows[indexgv]["LuongCB"].ToString();
                    txt_LopHienTai.Text = tb.Rows[indexgv]["TenLop"].ToString();
                    txt_MaLop.Text = tb.Rows[indexgv]["MaLop"].ToString();
                    t = DateTime.ParseExact(dtp_NgayVaoLam.Text, "dd/MM/yyyy", null);
                    txt_Lương.Text = Convert.ToInt32((int.Parse(txt_LuongCB.Text) * float.Parse(txt_HSL.Text) + (((DateTime.Now.Year - t.Year) / 100) + 1) * float.Parse(txt_HSL.Text))).ToString();
                    if (tb.Rows[indexgv]["GioiTinh"].ToString().Contains("Nam"))
                    {
                        rdb_Nam.Checked = true;
                        rdb_Nu.Checked = false;
                    }
                    else
                    {
                        rdb_Nu.Checked = true;
                        rdb_Nam.Checked = false;
                    }

                    //textBox10.Text = tb.Rows[indexTre]["GioiTinh"].ToString();
                    //}
                    //textBox1.Text = tb.Rows.Count.ToString();
                    //}
                    //DBNull db = null;
                    if (tb.Rows[indexgv]["Hinh"].ToString() == string.Empty )
                    {
                        imgBox.Image = null;
                    }
                    else
                    {
                        img = (byte[])(tb.Rows[indexgv]["Hinh"]);
                        if (img == null)
                        {
                            imgBox = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            imgBox.Image = Image.FromStream(ms);
                        }
                    }
                }
                con.Close();
            }
        }

        private void tSb_Xoa_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand cmd1 = new SqlCommand("DELETE FROM TaiKhoan WHERE MaGV = '" + txt_Ma.Text + "'", con);
                            cmd1.ExecuteNonQuery();
                        SqlCommand cmd = new SqlCommand("DELETE FROM GiaoVien WHERE MaGV= '" + txt_Ma.Text + "'", con);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã xóa thành công giáo viên này.", "Thông báo");

                        }

                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bạn không thể dùng tài khoản này để xóa chính mình. Hãy đăng nhập vào một tài khoản với quyền ADMIN để thực hiện điều này.", "Thông báo");
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    CapNhat();
                    clear(grp_TTHS);
                }
            }  
        }
        

        private string GioiTinh(RadioButton rdb)
        {
            if (rdb_Nam.Checked == true)
                return "Nam";
            return "Nữ";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.OrangeRed, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void tabPage_ThongTin_Click(object sender, EventArgs e)
        {

        }


        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void ts_ChucNang_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.OrangeRed, Color.White, LinearGradientMode.Vertical);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void frm_ThemGiaoVien_update__Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.DodgerBlue, Color.White, LinearGradientMode.Horizontal);
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

        private void tSb_Sua_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn thay đổi thông tin giáo viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
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

                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE GiaoVien SET TenGV = @TenGV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, NgayBatDau = @NgayBatDau, DiaChi = @DiaChi, CMND = @CMND, SDT = @SDT, TrinhDo = @TrinhDo, HSL = @HSL, LuongCB = @LuongCB, Hinh = @Hinh WHERE MaGV = N'" + txt_Ma.Text + "'", con);
                        cmd.Parameters.Add("@TenGV", txt_HoTen.Text);
                        cmd.Parameters.Add("@GioiTinh", GioiTinh(rdb_Nam));
                        cmd.Parameters.Add("@NgaySinh", txt_NgayThangNam.Text);
                        cmd.Parameters.Add("@NgayBatDau", dtp_NgayVaoLam.Text);
                        cmd.Parameters.Add("@DiaChi", txt_DiaChi.Text);
                        cmd.Parameters.Add("@CMND", txt_CMND.Text);
                        cmd.Parameters.Add("@SDT", txt_SDT.Text);
                        cmd.Parameters.Add("@TrinhDo", cbb_TrinhDo.Text);
                        cmd.Parameters.Add("@HSL", double.Parse(txt_HSL.Text));
                        cmd.Parameters.Add("@LuongCB", int.Parse(txt_LuongCB.Text));
                        cmd.Parameters.Add("@Hinh", img);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã cập nhật thông tin giáo viên này thành công.");
                        }
                        if (con.State == ConnectionState.Open)
                            con.Close();
                        CapNhat();
                        clear(grp_TTHS);
                        imgBox.ImageLocation = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhat();
            clear(grp_DSLH);
            clear(grp_TTHS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_PhanCong frm = new frm_PhanCong();
            frm.vt = _vt;
            frm.Show();
        }

        private void txt_HSL_TextChanged(object sender, EventArgs e)
        {
            if (txt_HSL.Text != string.Empty && txt_LuongCB.Text != string.Empty)
                txt_Lương.Text = Convert.ToInt64((Convert.ToInt64(txt_LuongCB.Text) * float.Parse(txt_HSL.Text) * (((DateTime.Now.Year - t.Year) / 100) + 1))).ToString();
        }

        private void txt_LuongCB_TextChanged(object sender, EventArgs e)
        {
            if (txt_HSL.Text != string.Empty && txt_LuongCB.Text != string.Empty)
                txt_Lương.Text = Convert.ToInt64((Convert.ToInt64(txt_LuongCB.Text) * float.Parse(txt_HSL.Text) * (((DateTime.Now.Year - t.Year) / 100) + 1))).ToString();
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
    }
}