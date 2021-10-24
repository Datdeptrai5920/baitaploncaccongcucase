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
    public partial class frm_KhoiLop : Form
    {
        public frm_KhoiLop()
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
        DataSet ds = new DataSet();
        bool save = true;
        bool save1 = true;
        private void frm_KhoiLop_Load(object sender, EventArgs e)
        {

            SqlDataAdapter sda;

            sda = new SqlDataAdapter("SELECT * from KhoiHoc", con);
            sda.Fill(ds, "KhoiHoc");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["KhoiHoc"].Columns[0];
            ds.Tables["KhoiHoc"].PrimaryKey = key;
            Gridview1.DataSource = ds.Tables["KhoiHoc"];
            Gridview1.Columns[0].HeaderText = "Mã khối";
            Gridview1.Columns[1].HeaderText = "Tên khối";

            sda = new SqlDataAdapter("SELECT * FROM LopHoc", con);
            sda.Fill(ds, "LopHoc");
            DataColumn[] pk = new DataColumn[1];
            pk[0] = ds.Tables["LopHoc"].Columns[0];
            ds.Tables["LopHoc"].PrimaryKey = pk;
            GV_LopHoc.DataSource = ds.Tables["LopHoc"];
            GV_LopHoc.Columns[0].HeaderText = "Mã Lớp";
            GV_LopHoc.Columns[1].HeaderText = "Tên Lớp";
            GV_LopHoc.Columns[2].HeaderText = "Mã khối";
            // GV_LopHoc.Columns[3].HeaderText = "Mã giáo viên";

            sda = new SqlDataAdapter("SELECT * FROM GiaoVien", con);
            sda.Fill(ds, "GiaoVien");
            DataColumn[] prk = new DataColumn[1];
            pk[0] = ds.Tables["GiaoVien"].Columns[0];
            ds.Tables["GiaoVien"].PrimaryKey = prk;

            cbb_MaKhoi.DataSource = ds.Tables["KhoiHoc"];
            cbb_MaKhoi.DisplayMember = "MaKhoi";
            cbb_MaKhoi.ValueMember = "MaKhoi";
            cbb_MaKhoi.SelectedValue = -1;

            //cbb_MaGV.DataSource = ds.Tables["GiaoVien"];
            //cbb_MaGV.DisplayMember = "MaGV";

            bt_Sửa.Enabled = false;
            bt_Xóa.Enabled = false;
            bt_Delete.Enabled = false;
            bt_Modify.Enabled = false;
        }
        private void Gridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Gridview1.Rows[e.RowIndex];
                txt_MaKhoi.Text = row.Cells[0].Value.ToString();
                txt_TenKhoi.Text = row.Cells[1].Value.ToString();
                bt_Them.Text = "Thêm"; bt_Them.ForeColor = Color.Black;
                bt_Xóa.Enabled = true; bt_Xóa.ForeColor = Color.Black;
                bt_Sửa.Enabled = true; bt_Sửa.ForeColor = Color.Black;
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (_vt == false)
            {
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (bt_Them.Text == "Thêm")
                {
                    bt_Xóa.Enabled = false;
                    bt_Sửa.Enabled = false;
                    txt_MaKhoi.Enabled = true;
                    txt_MaKhoi.Text = string.Empty;
                    txt_TenKhoi.Text = string.Empty;
                    bt_Them.Text = "Lưu";
                    bt_Them.ForeColor = Color.Blue;
                    bt_Sửa.Text = "Sửa";
                }
                else if (bt_Them.Text == "Lưu")
                {
                    if (txt_MaKhoi.Text == string.Empty || txt_TenKhoi.Text == string.Empty)
                    {
                        MessageBox.Show("Bạn hãy điền đầy đủ thông tin.");
                        return;
                    }
                    else
                    {
                        try
                        {
                            //string caulenh = "insert into KhoiHoc values('" + txt_MaKhoi.Text + "','" + txt_TenKhoi.Text + "')";
                            DataRow dr = ds.Tables["KhoiHoc"].NewRow();
                            dr[0] = txt_MaKhoi.Text;
                            dr[1] = txt_TenKhoi.Text;
                            ds.Tables["KhoiHoc"].Rows.Add(dr);
                            save = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mã khối đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        txt_MaKhoi.Enabled = false;
                        txt_MaKhoi.Text = "";
                        txt_TenKhoi.Text = "";
                        bt_Them.Text = "Thêm"; bt_Them.ForeColor = Color.Black;
                        cbb_MaKhoi.DataSource = ds.Tables["KhoiHoc"];
                        cbb_MaKhoi.DisplayMember = "MaKhoi";
                    }
                }
            }
        }

        private void bt_Xóa_Click(object sender, EventArgs e)
        {
            if (_vt == false)
            {
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    string MaKhoi = Gridview1.CurrentRow.Cells[0].Value.ToString();

                    DataRow dr = ds.Tables["KhoiHoc"].Rows.Find(MaKhoi);

                    if (dr != null)
                    {
                        dr.Delete();
                    }
                    txt_MaKhoi.Enabled = false;
                    txt_MaKhoi.Text = "";
                    txt_TenKhoi.Text = "";
                    save = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không thể cập nhật vào cở sở dữ liệu. Hãy chắc chắc khối học bạn xóa không còn lớp nào tồn tại, hoặc đảm bảo đã điền đầy đủ thông tin khi thêm hoặc chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (_vt == false)
            {
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
               
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from KhoiHoc", con);
                    try
                    {
                        SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                        sda.Update(ds, "KhoiHoc");
                        save = true;
                        MessageBox.Show("Cập nhật thành công vào cở sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể cập nhật vào cở sở dữ liệu. Hãy chắc chắc khối học bạn xóa không còn lớp nào tồn tại, hoặc đảm bảo đã điền đầy đủ thông tin khi thêm hoặc chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        sda.Fill(ds, "KhoiHoc");
                    }
                
            }
        }


        private void bt_Sửa_Click(object sender, EventArgs e)
        {
            if (_vt == false)
            {
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                DataRow dr = ds.Tables["KhoiHoc"].Rows.Find(txt_MaKhoi.Text);

                if (dr != null)
                {

                    if (bt_Sửa.Text == "Sửa")
                    {
                        bt_Xóa.Enabled = false;
                        bt_Them.Enabled = true;
                        txt_MaKhoi.Enabled = false;
                        txt_MaKhoi.Text = dr[0].ToString();
                        txt_TenKhoi.Text = dr[1].ToString();
                        bt_Sửa.Text = "Lưu";
                        bt_Sửa.ForeColor = Color.Blue;
                    }
                    else if (bt_Sửa.Text == "Lưu")
                    {

                        if (txt_TenKhoi.Text == string.Empty)
                        {
                            MessageBox.Show("Bạn chưa điền đầy đủ thông tin.");
                            return;
                        }

                        else
                        {
                            try
                            {
                                //string caulenh = "insert into KhoiHoc values('" + txt_MaKhoi.Text + "','" + txt_TenKhoi.Text + "')";
                                dr[1] = txt_TenKhoi.Text;
                                save = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Hãy điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            bt_Sửa.Text = "Sửa"; bt_Sửa.ForeColor = Color.Black;
                            txt_MaKhoi.Text = string.Empty;
                            txt_TenKhoi.Text = string.Empty;
                            bt_Sửa.Enabled = false;
                            bt_Xóa.Enabled = false;
                            save = false;
                        }
                    }
                   
                }
                
            }
        }

        private void frm_KhoiLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_vt == true)
            {
                if (save == false || save1 == false)
                {
                    DialogResult r = MessageBox.Show("Bạn có muốn cập nhật thay đổi vào cơ sỡ dữ liệu?", "Thông báo",
                                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                                       MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.OK)
                    {
                        if (save1 == false)
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from LopHoc", con);
                            try
                            {
                                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                                sda.Update(ds, "LopHoc");
                                //MessageBox.Show("Cập nhật thành công vào cở sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Không thể cập nhật vào cở sở dữ liệu. Hãy chắc chắc khối học bạn xóa không còn lớp nào tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sda.Fill(ds, "LopHoc");
                            }
                        }
                        if (save == false)
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from KhoiHoc", con);
                            try
                            {
                                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                                sda.Update(ds, "KhoiHoc");
                                save = true;
                                //MessageBox.Show("Cập nhật thành công vào cở sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Không thể cập nhật vào cở sở dữ liệu. Hãy chắc chắc khối học bạn xóa không còn lớp nào tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sda.Fill(ds, "KhoiHoc");
                            }
                        }
                    }
                }
            }
        }

        private void GV_LopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GV_LopHoc.Rows[e.RowIndex];
                txt_MaLop.Text = row.Cells[0].Value.ToString();
                txt_TenLop.Text = row.Cells[1].Value.ToString();
                cbb_MaKhoi.Text = row.Cells[2].Value.ToString();
                //cbb_MaGV.Text = row.Cells[3].Value.ToString();
                bt_Add.Text = "Thêm"; bt_Add.ForeColor = Color.Black;
                bt_Delete.Enabled = true; bt_Delete.ForeColor = Color.Black;
                bt_Modify.Enabled = true; bt_Modify.ForeColor = Color.Black;
                bt_Modify.Text = "Sửa";
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (_vt == false)
            {
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (bt_Add.Text == "Thêm")
                {
                    bt_Delete.Enabled = false;
                    bt_Modify.Enabled = false;
                    txt_MaLop.Enabled = true;
                    txt_MaLop.Text = string.Empty;
                    txt_TenLop.Text = "";
                    cbb_MaKhoi.Text = "";
                    bt_Add.Text = "Lưu";
                    bt_Add.ForeColor = Color.Blue;
                    bt_Modify.Text = "Sửa";

                }
                else if (bt_Add.Text == "Lưu")
                {
                    if (txt_MaLop.Text == string.Empty || txt_TenLop.Text == string.Empty || cbb_MaKhoi.Text == string.Empty)
                    {
                        MessageBox.Show("Bạn hãy điền đầy đủ thông tin.");
                        return;
                    }
                    else
                    {
                        try
                        {
                            //string caulenh = "insert into KhoiHoc values('" + txt_MaKhoi.Text + "','" + txt_TenKhoi.Text + "')";
                            DataRow dr = ds.Tables["LopHoc"].NewRow();
                            dr[0] = txt_MaLop.Text;
                            dr[1] = txt_TenLop.Text;
                            dr[2] = cbb_MaKhoi.Text;
                            //dr[3] = cbb_MaGV.Text;
                            ds.Tables["LopHoc"].Rows.Add(dr);
                            save1 = false;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mã lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        txt_MaLop.Enabled = false;
                        txt_MaLop.Text = "";
                        txt_TenLop.Text = "";
                        cbb_MaKhoi.SelectedValue = -1;
                        //cbb_MaGV.Text = "";
                        bt_Add.Text = "Thêm"; bt_Add.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (_vt == false)
            {
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                string MaLop = GV_LopHoc.CurrentRow.Cells[0].Value.ToString();

                DataRow dr = ds.Tables["LopHoc"].Rows.Find(MaLop);

                if (dr != null)
                {
                    dr.Delete();
                }
                txt_MaLop.Enabled = false;
                txt_MaLop.Text = "";
                txt_TenLop.Text = "";
                cbb_MaKhoi.Text = "";
                //cbb_MaGV.Text = "";
                save1 = false;
            }
        }

        private void bt_Modify_Click(object sender, EventArgs e)
        {
            if (_vt == false)
            {
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                DataRow dr = ds.Tables["LopHoc"].Rows.Find(txt_MaLop.Text);

                //if (dr != null)
                //{
                //    dr[1] = txt_TenLop.Text;
                //    dr[2] = cbb_MaKhoi.Text;
                //    //dr[3] = cbb_MaGV.Text;
                //}
                //save1 = false;
                if (dr != null)
                {

                    if (bt_Modify.Text == "Sửa")
                    {
                        bt_Delete.Enabled = false;
                        bt_Add.Enabled = true;
                        txt_MaLop.Enabled = false;
                        txt_MaLop.Text = dr[0].ToString();
                        txt_TenLop.Text = dr[1].ToString();
                        cbb_MaKhoi.Text = dr[2].ToString();
                        bt_Modify.Text = "Lưu";
                        bt_Modify.ForeColor = Color.Blue;
                    }
                    else if (bt_Modify.Text == "Lưu")
                    {
                        if (txt_TenLop.Text == string.Empty || cbb_MaKhoi.Text == string.Empty)
                        {
                            MessageBox.Show("Bạn hãy điền đầy đủ thông tin.");
                            return;
                        }
                        else
                        {
                            try
                            {
                                //string caulenh = "insert into KhoiHoc values('" + txt_MaKhoi.Text + "','" + txt_TenKhoi.Text + "')";
                                dr[1] = txt_TenLop.Text;
                                dr[2] = cbb_MaKhoi.Text;
                                save1 = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Hãy điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            bt_Modify.Text = "Sửa"; bt_Modify.ForeColor = Color.Black;
                            txt_MaLop.Text = string.Empty;
                            txt_TenLop.Text = string.Empty;
                            cbb_MaKhoi.SelectedValue = -1;
                            bt_Modify.Enabled = false;
                            bt_Delete.Enabled = false;
                            save1 = false;
                        }
                    }
                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (_vt == false)
            {
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from LopHoc", con);
                try
                {
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.Update(ds, "LopHoc");
                    save1 = true;
                    MessageBox.Show("Cập nhật thành công vào cở sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể cập nhật vào cở sở dữ liệu. Hãy chắc chắc khối học bạn xóa không còn lớp nào tồn tại, hoặc đảm bảo đã điền đầy đủ thông tin khi thêm hoặc chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sda.Fill(ds, "LopHoc");
                }
            }
        }

        private void frm_KhoiLop_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
    }
}
