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
    public partial class frm_PhanCong : Form
    {
        public frm_PhanCong()
        {
            InitializeComponent();
        }

        private bool _vt;
        bool save = true;
        public bool vt
        {
            get { return _vt; }
            set { _vt = value; }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|CoSoDuLieu.mdf;Integrated Security=True;");
        DataTable dt_combobox = new DataTable();
        DataTable dt = new DataTable();

        private void disable_cell(bool f)
        {
            dGV_PhanCong.Columns[0].ReadOnly = f;
            dGV_PhanCong.Columns[1].ReadOnly = f;
            dGV_PhanCong.Columns[2].ReadOnly = f;
        }
        private void frm_PhanCong_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(0, 0, 0, 0);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT MaGV, TenGV, GiaoVien.MaLop FROM GiaoVien, LopHoc GROUP BY MaGV, TenGV, GiaoVien.MaLop", con);
            //DataTable dt = new DataTable();
            sda.Fill(dt);
            dGV_PhanCong.DataSource = dt;

            
        

            //DataTable dt_combobox = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM LopHoc", con);
            sd.Fill(dt_combobox);
            DataGridViewComboBoxColumn col_combobox = (DataGridViewComboBoxColumn)dGV_PhanCong.Columns["col_TenLop"];
            col_combobox.Items.Add(string.Empty);
            col_combobox.DataSource = dt_combobox;
            col_combobox.ValueMember = "MaLop";
            col_combobox.DisplayMember = "TenLop";

            cbb_KhoiHoc.Items.Add("Tất cả");
            foreach(DataRow row in dt_combobox.Rows)
            {
                cbb_KhoiHoc.Items.Add(row[1].ToString());
            }

            //disable_cell(true);
            dGV_PhanCong.CellEndEdit += new DataGridViewCellEventHandler(dGV_PhanCong_CellEndEdit);
            dGV_PhanCong.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dGV_PhanCong_EditingControlShowing);

            
        }

        private void dGV_PhanCong_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (cb != null)
            //    cb.SelectedIndexChanged -= new EventHandler(cb_SelectedIndexChanged);
        }
        DataGridViewCell cell;

        private void dGV_PhanCong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dGV_PhanCong_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //dGV_PhanCong.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        //int i = 1;
        ComboBox cb = new ComboBox();
        private void dGV_PhanCong_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            cell = this.dGV_PhanCong.CurrentCell;
            cb = e.Control as ComboBox;
            if (cb != null)
            {
                cb.SelectedIndexChanged -= new EventHandler(cb_SelectedIndexChanged);
                cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged);
            }

            //if(e.Control is ComboBox)
            //{
            //    cb = (ComboBox)e.Control;
            //    if (cb != null)
            //        cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged);
            //    //cell = this.dGV_PhanCong.CurrentCell;
            //}
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cb != null)
            //{
            //    DataRowView drv = cb.SelectedItem as DataRowView;
            //    if (drv != null)
            //    {
            //        //disable_cell(false);
            //        this.dGV_PhanCong[2, cell.RowIndex].Value = MaLop(cb);
            //        //disable_cell(true);
            //        save = false;
            //    }
            //}

            this.dGV_PhanCong[2, cell.RowIndex].Value = ((ComboBox)sender).SelectedValue;
            cb.SelectedIndexChanged -= new EventHandler(cb_SelectedIndexChanged);
        }

        private string MaLop(ComboBox cbb)
        {
            string s = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT MaLop FROM LopHoc where TenLop = N'" + cbb.Text + "'", con);
            //cmd.Parameters.AddWithValue("@TenLop", cbb_LopMoi.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                s = dr["MaLop"].ToString();
            }
            con.Close();
            return s;
        }
        void EndEdit()
        {
            
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (_vt == false)
                MessageBox.Show("Bạn không được phép sử dụng chức năng này.", "Thông báo", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd;
                    foreach (DataGridViewRow row in dGV_PhanCong.Rows)
                    {
                        //DataRow row = drv.Row;
                        cmd = new SqlCommand("UPDATE GiaoVien SET MaLop ='" + row.Cells[2].Value.ToString() + "' WHERE MaGV = '" + row.Cells[0].Value.ToString() + "'", con);
                        //cmd.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }


        private void bt_HienThi_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            DataTable table = new DataTable();
            if(cbb_KhoiHoc.Text == "Tất cả")
                sda = new SqlDataAdapter("SELECT MaGV, TenGV, GiaoVien.MaLop FROM GiaoVien, LopHoc GROUP BY MaGV, TenGV, GiaoVien.MaLop", con);
            else
                sda = new SqlDataAdapter("SELECT MaGV, TenGV, GiaoVien.MaLop FROM GiaoVien, LopHoc WHERE GiaoVien.MaLop = '"+MaLop(cbb_KhoiHoc)+"' GROUP BY MaGV, TenGV, GiaoVien.MaLop", con);
            sda.Fill(table);
            dGV_PhanCong.DataSource = table;
        }

        private void frm_PhanCong_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightGreen, Color.White, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

       
    }
}
