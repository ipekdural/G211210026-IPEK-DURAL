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
    public partial class draw_rect_rect : Form
    {
        public int x;
        public draw_rect_rect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dikdortgen_dikdortgen d = new dikdortgen_dikdortgen();
            this.Hide();
            d.Show();
        }
        private void draw_rect_rect_Paint(object sender, PaintEventArgs e)
        {

            if (x == 1)
            {
                label1.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                g.DrawRectangle(p, 200, 200, 300, 200);
                g.DrawRectangle(p, 350, 250, 300, 200);

            }
            else
            {
                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                g.DrawRectangle(p, 250, 150, 200, 100);
                g.DrawRectangle(p, 350, 300, 200, 100);
                x = 0;
            }
        }





    }
}
