using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongMamNon
{
    class MyNewTabControl : TabControl
    {
        private Point _lastClickPos;
        private ContextMenuStrip _CMS;

        public MyNewTabControl()
        {
            _CMS = GetCMS();
        }

        private ContextMenuStrip GetCMS()
        {
            ContextMenuStrip CMS = new ContextMenuStrip();
            CMS.Items.Add("Đóng", null, new EventHandler(Item_Clicked));
            return CMS;
        }

        private void Item_Clicked(object sender, EventArgs e)
        {
            for(int i = 0; i < this.TabCount; i++)
            {
                Rectangle rect = this.GetTabRect(i);
                if (i == 0)
                    continue;
                if(rect.Contains(this.PointToClient(_lastClickPos)))
                {
                    this.TabPages.RemoveAt(i);
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                _lastClickPos = Cursor.Position;
                _CMS.Show(Cursor.Position);
            }
        }
    }
}
