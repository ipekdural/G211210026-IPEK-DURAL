using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje1
{
    public partial class draw_rect_circle : Form
    {
        public int x;
        public draw_rect_circle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dikdortgen_cember d = new dikdortgen_cember();
            d.Show();
        }

        private void draw_rect_circle_Paint(object sender, PaintEventArgs e)
        {
            if (x == 1)
            {
                label1.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                g.DrawRectangle(p, 400, 200, 200, 100);
                e.Graphics.DrawEllipse(p, 320 - 90, 200 - 90, 250, 250);

            }
            else
            {
                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                g.DrawRectangle(p, 470, 200, 200, 100);
                e.Graphics.DrawEllipse(p, 250 - 80, 200 - 80, 250, 250);
                x = 0;
            }
        }
    }
}
