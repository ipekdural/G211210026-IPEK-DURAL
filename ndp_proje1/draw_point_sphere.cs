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

    public partial class draw_point_sphere : Form
    {
        public int x;
        public draw_point_sphere()
        {
            InitializeComponent();
        }

        private void draw_point_sphere_Paint(object sender, PaintEventArgs e)
        {
            if (x == 1)
            {
                label1.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.White, 5);
                //g.FillEllipse(Brushes.White, 350, 300, 5, 5);
                g.FillEllipse(Brushes.Lime, 300, 100, 300, 300);
                g.DrawEllipse(p, 400, 200, 5, 5);

            }
            else
            {
                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.White, 5);
                //g.FillEllipse(Brushes.White, 350, 300, 5, 5);
                g.FillEllipse(Brushes.Lime, 300, 100, 300, 300);
                g.DrawEllipse(p, 200, 150, 5, 5);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nokta_kure nokta_Kure = new nokta_kure();
            this.Hide();
            nokta_Kure.Show();
        }
    }
}
