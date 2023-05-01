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
    public partial class cember_cember : Form
    {
        public int control = 0;
        Circle circle1 = new Circle();
        Circle circle2 = new Circle();
        public cember_cember()
        {
            InitializeComponent();
        }


        public void cemberCember()
        {

            circle1.x = (int)numericUpDown1.Value;
            circle1.y = (int)numericUpDown2.Value;
            circle1.radius = (int)numericUpDown3.Value;


            circle2.x = (int)numericUpDown4.Value;
            circle2.y = (int)numericUpDown5.Value;
            circle2.radius = (int)numericUpDown6.Value;

            int distance = (int)Math.Sqrt(Math.Pow(circle1.x - circle2.x, 2) + Math.Pow(circle1.y - circle2.y, 2));
            if (distance <= (circle1.radius + circle2.radius))
            {
                MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 1;
            }
            else
            {

                MessageBox.Show("Collision has not occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 0;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        class Circle
        {
            public int x;
            public int y;
            public int radius;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_circle_circle draw_Circle_Circle = new draw_circle_circle();
            draw_Circle_Circle.x = control;
            this.Hide();
            draw_Circle_Circle.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cemberCember();
            button2.Enabled = true;
        }
    }
}
