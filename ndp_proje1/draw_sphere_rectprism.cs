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
    public partial class draw_sphere_rectprism : Form
    {
        public int x;
        public draw_sphere_rectprism()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kure_dikdortgenler_prizmasi k = new kure_dikdortgenler_prizmasi();
            k.Show();
            this.Hide();
        }

        private void draw_sphere_rectprism_Paint(object sender, PaintEventArgs e)
        {

            if (x == 1)
            {
                label1.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p1 = new Pen(System.Drawing.Color.Red, 10);
                Pen p2 = new Pen(System.Drawing.Color.Blue, 10);
                g.DrawEllipse(p1, 400, 250, 200, 200);
                g.FillEllipse(Brushes.PaleVioletRed, 400, 250, 200, 200);
                Pen p=new Pen(Color.PaleGreen, 10);
                g.DrawRectangle(p, 200, 200, 200, 300);
                g.DrawLine(p, 200, 200, 300, 100);
                g.DrawLine(p, 400, 200, 500, 100);
                g.DrawLine(p, 500, 100, 500, 400);
                g.DrawLine(p, 400, 500, 500, 400);
                g.DrawLine(p, 300, 100, 500, 100);



            }
            else
            {
                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p1 = new Pen(System.Drawing.Color.Red, 10);
                Pen p2 = new Pen(System.Drawing.Color.Blue, 10);
                g.DrawEllipse(p1, 750, 250, 200, 200);
                g.FillEllipse(Brushes.PaleVioletRed, 750, 250, 200, 200);
                Pen p = new Pen(Color.PaleGreen, 10);
                g.DrawRectangle(p, 200, 200, 200, 300);
                g.DrawLine(p, 200, 200, 300, 100);
                g.DrawLine(p, 400, 200, 500, 100);
                g.DrawLine(p, 500, 100, 500, 400);
                g.DrawLine(p, 400, 500, 500, 400);
                g.DrawLine(p, 300, 100, 500, 100);





            }
        }
    }
}
