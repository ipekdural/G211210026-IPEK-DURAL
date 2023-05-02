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
    public partial class draw_2rectprism : Form
    {
        public int x;
        public draw_2rectprism()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dikdortgenler_prizması2 d = new dikdortgenler_prizması2();
            d.Show();
            this.Hide();
        }

        private void draw_2rectprism_Paint(object sender, PaintEventArgs e)
        {

            if (x == 1)
            {
                label1.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen k = new Pen(Color.Red, 8);
                Pen p = new Pen(Color.Blue, 8);
                g.DrawRectangle(p, 200, 200, 200, 300);
                g.DrawLine(p, 200, 200, 300, 100);
                g.DrawLine(p, 400, 200, 500, 100);
                g.DrawLine(p, 500, 100, 500, 400);
                g.DrawLine(p, 400, 500, 500, 400);
                g.DrawLine(p, 300, 100, 500, 100);


                g.DrawRectangle(k, 300, 300, 200, 300);
                g.DrawLine(k, 300, 300, 400, 200);
                g.DrawLine(k, 400, 200, 600, 200);
                g.DrawLine(k, 500, 300, 600, 200);
                g.DrawLine(k, 600, 200, 600, 500);
                g.DrawLine(k, 500, 600, 600, 500);




            }
            else
            {

                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen k = new Pen(Color.Red, 8);
                Pen p = new Pen(Color.Blue, 8);
                g.DrawRectangle(p, 200, 200, 200, 300);
                g.DrawLine(p, 200, 200, 300, 100);
                g.DrawLine(p, 400, 200, 500, 100);
                g.DrawLine(p, 500, 100, 500, 400);
                g.DrawLine(p, 400, 500, 500, 400);
                g.DrawLine(p, 300, 100, 500, 100);


                g.DrawRectangle(k, 500, 500, 200, 300);
                g.DrawLine(k, 500, 500, 600, 400);
                g.DrawLine(k, 600, 400, 800, 400);
                g.DrawLine(k, 700, 500, 800, 400);
                g.DrawLine(k, 800, 400, 800, 700);
                g.DrawLine(k, 700, 800, 800, 700);




            }
        }
    }
}
