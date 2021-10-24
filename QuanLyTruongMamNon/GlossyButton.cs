using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Configuration;

namespace QuanLyTruongMamNon
{
    public partial class GlossyButton : UserControl
    {
        public GlossyButton()
        {
            InitializeComponent();
        }

        // Import the Gdi32 DLL
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        // Import the Method from DLL. With this method you can create a Form with rounded corners
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int wEllipse, int hEllipse);
        // Create a Pen that will draw the border of the button.
        Pen p = new Pen(Color.Aqua);
        // Configure the BtnText Property
        [Description("The text associated with the control")]
        [Category("Appearance")]
        public string BtnText
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
                label1.Location = new Point(this.Width / 2 - label1.Width / 2, this.Height / 2 - label1.Height / 2);
            }
        }
        // Set the font of label1 through the Font Property of GlossyButton
        public override Font Font
        {
            get
            {
                return label1.Font;
            }
            set
            {
                label1.Font = value;
                // Center the label
                label1.Location = new Point(this.Width / 2 - label1.Width / 2, this.Height / 2 - label1.Height / 2);
            }
        }

        protected void onMouseEnter()
        {
            p.Color = Color.Red; this.BackColor = Color.Firebrick; this.Invalidate();
        }

        protected void onMouseDown()
        {
            this.BackColor = Color.Maroon; this.Invalidate();
        }

        protected void NormalStyle()
        {
            p.Color = Color.Aqua; this.BackColor = Color.DodgerBlue; this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width + 1, this.Height + 1, 3, 3));
            LinearGradientBrush lb = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), Color.FromArgb(150, Color.White), Color.FromArgb(50, Color.White), LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(lb, 2, 2, this.Width - 6, this.Height / 2);
            e.Graphics.DrawRectangle(p, 0, 0, this.Width - 3, this.Height - 3);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            label1.Location = new Point(this.Width / 2 - label1.Width / 2, this.Height / 2 - label1.Height / 2);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            onMouseEnter();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            NormalStyle();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            onMouseDown();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            onMouseEnter();
        }
        private void GlossyButton_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            onMouseEnter();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            NormalStyle();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            onMouseDown();
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            onMouseEnter();
        }
    }
}
