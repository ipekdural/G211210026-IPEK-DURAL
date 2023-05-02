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
    public partial class draw_sphere_cylinder : Form
    {
        public int x;
        public draw_sphere_cylinder()
        {
            InitializeComponent();
        }

        private void draw_sphere_cylinder_Paint(object sender, PaintEventArgs e)
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
                e.Graphics.DrawEllipse(p2, 300, 200, 200, 100);
                e.Graphics.DrawEllipse(p2, 300, 450, 200, 100);
                e.Graphics.DrawLine(p2, 300, 250, 300, 500);
                e.Graphics.DrawLine(p2, 500, 250, 500, 500);




            }
            else
            {
                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p1 = new Pen(System.Drawing.Color.Red, 10);
                Pen p2 = new Pen(System.Drawing.Color.Blue, 10);
                g.DrawEllipse(p1, 650, 250, 200, 200);
                g.FillEllipse(Brushes.PaleVioletRed, 650, 250, 200, 200);
                e.Graphics.DrawEllipse(p2, 300, 200, 200, 100);
                e.Graphics.DrawEllipse(p2, 300, 450, 200, 100);
                e.Graphics.DrawLine(p2, 300, 250, 300, 500);
                e.Graphics.DrawLine(p2, 500, 250, 500, 500);





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kure_silindir k = new kure_silindir();
            this.Hide();
            k.Show();
        }
    }
}
