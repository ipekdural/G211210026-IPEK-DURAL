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
    public partial class dikdortgen_cember : Form
    {
        public int control;
        Rectangle rectangle1 = new Rectangle();
        Circle circle1 = new Circle();

        public dikdortgen_cember()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            dikdortgenCember();
            button2.Enabled = true;
        }
        public void dikdortgenCember()
        {
            rectangle1.x = (int)numericUpDown1.Value;
            rectangle1.y = (int)numericUpDown2.Value;
            rectangle1.height = (int)numericUpDown3.Value;
            rectangle1.width = (int)numericUpDown4.Value;

            circle1.x = (int)numericUpDown5.Value;
            circle1.y = (int)numericUpDown6.Value;
            circle1.radius = (int)numericUpDown7.Value;



            if (circle1.x + circle1.radius >= rectangle1.x && circle1.x - circle1.radius <= rectangle1.x + rectangle1.width && circle1.x + circle1.radius >= rectangle1.y && circle1.y - circle1.radius <= rectangle1.y + rectangle1.height)
            {
                MessageBox.Show("Collision has occurred!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                control = 1;
            }

            else
            {
                MessageBox.Show("Collision has not  occurred!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 0;
            }
        }
        public class Rectangle
        {
            public int x;
            public int y;
            public int width;
            public int height;
        }
        class Circle
        {
            public int x;
            public int y;
            public int radius;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_rect_circle draw_Rect_Circle = new draw_rect_circle();
            draw_Rect_Circle.x = control;
            this.Hide();
            draw_Rect_Circle.Show();

        }
    }
}
