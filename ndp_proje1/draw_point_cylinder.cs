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
    public partial class draw_point_cylinder : Form
    {
        public int x;
        public draw_point_cylinder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nokta_silindir n = new nokta_silindir();
            this.Hide();
            n.Show();
        }

        private void draw_point_cylinder_Paint(object sender, PaintEventArgs e)
        {

            if (x == 1)
            {

                label1.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                e.Graphics.DrawEllipse(p, 300, 200, 200, 100);
                e.Graphics.DrawEllipse(p, 300, 450, 200, 100);
                e.Graphics.DrawLine(p, 300, 250, 300, 500);
                e.Graphics.DrawLine(p, 500, 250, 500, 500);
                g.FillEllipse(Brushes.Red, 350, 350, 10, 10);
          

            }
            else
            {

                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);

                e.Graphics.DrawEllipse(p, 300, 200, 200, 100);
                e.Graphics.DrawEllipse(p, 300, 450, 200, 100);
                e.Graphics.DrawLine(p, 300, 250, 300, 500);
                e.Graphics.DrawLine(p, 500, 250, 500, 500);
                g.FillEllipse(Brushes.Red, 150, 150, 10, 10);



            }
        }
    }
}
