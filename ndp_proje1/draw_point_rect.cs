using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ndp_proje1.nokta_dortgen;

namespace ndp_proje1
{
    public partial class draw_point_rect : Form
    {
        public int x;

        public draw_point_rect()
        {

            InitializeComponent();


        }





        private void draw_point_rect_Paint(object sender, PaintEventArgs e)
        {

            if (x == 1)
            {
                timer1.Start();
                label1.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                g.DrawRectangle(p, 300, 200, 300, 200);
                g.FillEllipse(Brushes.Lime, 400, 300, 5, 5);
  
            }
            else
            {
                timer2.Start();
                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                g.DrawRectangle(p, 300, 200, 300, 200);
                g.FillEllipse(Brushes.Lime, 150, 150, 5, 5);
                x = 0;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                label1.Visible = false;
                i = 0;
            }


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                label2.Visible = false;
                i = 0;
            }


        }
        private void draw_point_rect_Load(object sender, EventArgs e)
        {

            timer1.Interval = 2000;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            nokta_dortgen d = new nokta_dortgen();
            d.Show();
        }
    }
}
