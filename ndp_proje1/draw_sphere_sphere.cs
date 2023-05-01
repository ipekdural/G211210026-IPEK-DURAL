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
    public partial class draw_sphere_sphere : Form
    {
        public int x;
        public draw_sphere_sphere()
        {
            InitializeComponent();
        }

        private void draw_sphere_sphere_Paint(object sender, PaintEventArgs e)
        {

            if (x == 1)
            {
                label1.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p1 = new Pen(System.Drawing.Color.Red, 20);
                Pen p2 = new Pen(System.Drawing.Color.Blue, 20);

                g.DrawEllipse(p1, 300, 100, 300, 300);
                g.DrawEllipse(p2, 500, 100, 300, 300);
                g.FillEllipse(Brushes.PaleVioletRed, 300, 100, 300, 300);
                g.FillEllipse(Brushes.LightBlue, 500, 100, 300, 300);


            }
            else
            {
                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();

                Pen p1 = new Pen(System.Drawing.Color.Red, 20);
                Pen p2 = new Pen(System.Drawing.Color.Blue, 20);

                g.DrawEllipse(p1, 100, 100, 300, 300);
                g.DrawEllipse(p2, 500, 100, 300, 300);
                g.FillEllipse(Brushes.PaleVioletRed, 100, 100, 300, 300);
                g.FillEllipse(Brushes.LightBlue, 500, 100, 300, 300);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kure_kure k = new kure_kure();
            k.Show();
            this.Hide();
        }
    }
}
