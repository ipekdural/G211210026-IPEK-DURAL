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
    public partial class nokta_dikdortgenler_prizmasi : Form
    {
        public int control = 0;
        RectPrism rectPrism1 = new RectPrism();
        _Point point1 = new _Point();
        public nokta_dikdortgenler_prizmasi()
        {
            InitializeComponent();
        }

        public void dikdortgenlerprizmasiNokta()
        {
            point1.x = (int)numericUpDown1.Value;
            point1.y = (int)numericUpDown2.Value;
            point1.z = (int)numericUpDown3.Value;
            rectPrism1.x = (int)numericUpDown4.Value;
            rectPrism1.y = (int)numericUpDown5.Value;
            rectPrism1.z = (int)numericUpDown6.Value;
            rectPrism1.width = (int)numericUpDown7.Value;
            rectPrism1.height = (int)numericUpDown8.Value;
            rectPrism1.depth = (int)numericUpDown9.Value;


            double distance = (double)Math.Sqrt(Math.Pow((point1.x - rectPrism1.x), 2) + Math.Pow((point1.y - rectPrism1.y), 2) + Math.Pow((point1.z - rectPrism1.z), 2));
            if (distance <= ((rectPrism1.width) / 2 + (rectPrism1.height) / 2 + (rectPrism1.depth) / 2))
            {
                MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 1;
            }
            else
            {
                MessageBox.Show("Collision has not occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        class RectPrism
        {
            public int x;
            public int y;
            public int z;
            public int width;
            public int height;
            public int depth;

        }
        class _Point
        {

            public int x;
            public int y;
            public int z;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            dikdortgenlerprizmasiNokta();
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_point_rect_prism draw_Point_Rect_Prism = new draw_point_rect_prism();
            draw_Point_Rect_Prism.x = control;
            this.Hide();
            draw_Point_Rect_Prism.Show();

        }
    }

}
