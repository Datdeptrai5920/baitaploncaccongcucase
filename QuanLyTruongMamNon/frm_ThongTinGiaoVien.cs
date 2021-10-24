using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace QuanLyTruongMamNon
{
    public partial class frm_ThongTinGiaoVien : Form
    {
        public frm_ThongTinGiaoVien()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void ts_ChucNang_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tSb_Them_Click(object sender, EventArgs e)
        {
            //TabPage t = new TabPage();
            //foreach(Control ctr in tabPage1.Controls)
            //{
            //    t.Controls = ctr.
            //}
            //tab_GiaoVien.TabPages.Add(t);

            // as will your original TabPage
            //TabPage tpOld = tab_GiaoVien.SelectedTab;

            //TabPage tpNew = new TabPage();
            //foreach (Control c in tab_GiaoVien.TabPages[0].Controls)
            //{
            //    Control cNew = (Control)Activator.CreateInstance(c.GetType());

            //    PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(c);

            //    foreach (PropertyDescriptor entry in pdc)
            //    {
            //        object val = entry.GetValue(c);
            //        entry.SetValue(cNew, val);
            //    }

            //    // add control to new TabPage
            //    tpNew.Controls.Add(cNew);
            //}

            //tab_GiaoVien.TabPages.Add(tpNew);
            tab_GiaoVien.TabPages.Add(new MyTabPage(new frm_ThemGiaoVien()));
        }

        const int LEADING_SPACE = 12;
        const int CLOSE_SPACE = 15;
        const int CLOSE_AREA = 15;
        private void tab_GiaoVien_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tab_GiaoVien.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 20, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void frm_ThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            int tabLength = tab_GiaoVien.ItemSize.Width;

            // measure the text in each tab and make adjustment to the size
            for (int i = 0; i < this.tab_GiaoVien.TabPages.Count; i++)
            {
                TabPage currentPage = tab_GiaoVien.TabPages[i];

                int currentTabLength = TextRenderer.MeasureText(currentPage.Text, tab_GiaoVien.Font).Width;
                // adjust the length for what text is written
                currentTabLength += LEADING_SPACE + CLOSE_SPACE + CLOSE_AREA;

                if (currentTabLength > tabLength)
                {
                    tabLength = currentTabLength;
                }
            }

            // create the new size
            Size newTabSize = new Size(tabLength, tab_GiaoVien.ItemSize.Height);
            tab_GiaoVien.ItemSize = newTabSize;
        }
       


    }
}
