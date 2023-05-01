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

    public partial class draw_point_rect_prism : Form
    {
        public int x;
        public draw_point_rect_prism()
        {
            InitializeComponent();
        }

        private void draw_point_rect_prism_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nokta_dikdortgenler_prizmasi d = new nokta_dikdortgenler_prizmasi();
            this.Hide();
            d.Show();
        }

        private void draw_point_rect_prism_Paint(object sender, PaintEventArgs e)
        {

            if (x == 1)
            {

                //x1: İlk noktanın x koordinatı.
                //y1: İlk noktanın y koordinatı.
                //x2: İkinci noktanın x koordinatı.
                //y2: İkinci noktanın y koordinatı.
                //DrawLine(Pen pen, float x1, float y1, float x2, float y2)

                label1.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                g.DrawRectangle(p,200, 200, 200, 300);
                g.DrawLine(p, 200, 200, 300, 100);
                g.DrawLine(p, 400, 200, 500, 100);
                g.DrawLine(p, 500, 100, 500, 400);
                g.DrawLine(p, 400, 500, 500, 400);
                g.DrawLine(p, 300, 100, 500, 100);
                g.FillEllipse(Brushes.Lime, 300, 300, 10, 10);




            }
            else
            {

                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                g.DrawRectangle(p, 200, 200, 200, 300);
                g.DrawLine(p, 200, 200, 300, 100);
                g.DrawLine(p, 400, 200, 500, 100);
                g.DrawLine(p, 500, 100, 500, 400);
                g.DrawLine(p, 400, 500, 500, 400);
                g.DrawLine(p, 300, 100, 500, 100);
                g.FillEllipse(Brushes.Lime, 150, 100, 10, 10);


            }
        }
    }
}
