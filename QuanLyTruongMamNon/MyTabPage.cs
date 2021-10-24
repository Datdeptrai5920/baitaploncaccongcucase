using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongMamNon
{
    public class MyFormPage:Form
    {
        public Panel pnl;
    }
    public class MyTabPage:TabPage
    {
        private Form frm;
        public MyTabPage(MyFormPage form)
        {
            this.frm = form;
            this.Controls.Add(form.pnl);
            this.Text = form.Text;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                frm.Dispose();
            base.Dispose(disposing);
        }
    }
}
