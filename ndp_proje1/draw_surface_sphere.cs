using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje1
{
    public partial class draw_surface_sphere : Form
    {
        public int x;
        public draw_surface_sphere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yuzey_kure y = new yuzey_kure();
            y.Show();
            this.Hide();
        }

        private void draw_surface_sphere_Paint(object sender, PaintEventArgs e)
        {
            if (x == 1)
            {

                label1.Visible = true;
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.White, 2);
                int x1 = 200, y1 = 200, x2 = 600, y2 = 350;
                int bosluk = 30;
                for (int i = 0; i < 10; i++)
                {
                    g.DrawLine(pen, x1, y1 + i * 30, x2, y2 + i * bosluk);
                }

                for (int i = 0; i < 10; i++)
                {
                    g.DrawLine(pen, x1 + i * bosluk, y1, x2 + i * bosluk, y2);
                }

                for (int i = 0; i < 10; i++)
                {
                    g.DrawLine(pen, 600, y2 + i * bosluk, 885, y2 + i * bosluk);
                }
                Pen pk = new Pen(Color.Red, 2);
                g.DrawLine(pk, 600, 350, 600, 700);
                g.DrawLine(pk, 600, 350, 950, 350);
                g.DrawLine(pk, 200, 200, 600, 350);

                Pen p1 = new Pen(System.Drawing.Color.Red, 5);


                g.DrawEllipse(p1, 350, 150, 200, 200);

                g.FillEllipse(Brushes.PaleVioletRed, 350, 150, 200, 200);



            }
            else
            {

                label2.Visible = true;
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.White, 2);
                int x1 = 200, y1 = 200, x2 = 600, y2 = 350;
                int bosluk = 30;
                for (int i = 0; i < 10; i++)
                {
                    g.DrawLine(pen, x1, y1 + i * 30, x2, y2 + i * bosluk);
                }

                for (int i = 0; i < 10; i++)
                {
                    g.DrawLine(pen, x1 + i * bosluk, y1, x2 + i * bosluk, y2);
                }

                for (int i = 0; i < 10; i++)
                {
                    g.DrawLine(pen, 600, y2 + i * bosluk, 885, y2 + i * bosluk);
                }
                Pen pk = new Pen(Color.Red, 2);
                g.DrawLine(pk, 600, 350, 600, 700);
                g.DrawLine(pk, 600, 350, 950, 350);
                g.DrawLine(pk, 200, 200, 600, 350);

                Pen p1 = new Pen(System.Drawing.Color.Red, 5);


                g.DrawEllipse(p1, 150, 150, 50, 50);

                g.FillEllipse(Brushes.PaleVioletRed, 150, 150, 50, 50);

            }
        }
    }
}
