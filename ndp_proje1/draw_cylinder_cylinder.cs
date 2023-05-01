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
    public partial class draw_cylinder_cylinder : Form
    {
        public int x;
        public draw_cylinder_cylinder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            silindir_silindir s = new silindir_silindir();
            this.Hide();
            s.Show();
        }

        private void draw_cylinder_cylinder_Paint(object sender, PaintEventArgs e)
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

                e.Graphics.DrawEllipse(p, 400, 200, 200, 100);
                e.Graphics.DrawEllipse(p, 400, 450, 200, 100);
                e.Graphics.DrawLine(p, 400, 250, 400, 500);
                e.Graphics.DrawLine(p, 600, 250, 600, 500);



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

                e.Graphics.DrawEllipse(p, 600, 200, 200, 100);
                e.Graphics.DrawEllipse(p, 600, 450, 200, 100);
                e.Graphics.DrawLine(p, 600, 250, 600, 500);
                e.Graphics.DrawLine(p, 800, 250, 800, 500);


            }
        }
    }
}
