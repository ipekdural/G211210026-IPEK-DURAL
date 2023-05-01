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
    public partial class draw_circle_circle : Form
    {
        public int x;
        public draw_circle_circle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            cember_cember d = new cember_cember();
            d.Show();
        }

    

        private void draw_circle_circle_Paint(object sender, PaintEventArgs e)
        {
            if (x == 1)
            {

                label1.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                e.Graphics.DrawEllipse(p, 250, 200, 200, 200);
                e.Graphics.DrawEllipse(p, 350, 200, 200, 200);

            }
            else
            {

                label2.Visible = true;
                System.Drawing.Graphics g;
                g = this.CreateGraphics();
                Pen p = new Pen(System.Drawing.Color.Lime, 5);
                e.Graphics.DrawEllipse(p, 250, 200, 200, 200);
                e.Graphics.DrawEllipse(p, 500, 200, 200, 200);





            }
        }
    }
}
