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
    public partial class kure_dikdortgenler_prizmasi : Form
    {
        int control = 0;
        Sphere sphere1 = new Sphere();
        RectPrism rectPrism1 = new RectPrism();
        public kure_dikdortgenler_prizmasi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)//sil
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kureDikdortgenlerPrizmasi();
            button2.Enabled = true;

        }
        public void kureDikdortgenlerPrizmasi()
        {
            sphere1.x = (int)numericUpDown1.Value;
            sphere1.y = (int)numericUpDown2.Value;
            sphere1.z = (int)numericUpDown3.Value;
            sphere1.radius = (int)numericUpDown4.Value;

            rectPrism1.x = (int)numericUpDown5.Value;
            rectPrism1.y = (int)numericUpDown6.Value;
            rectPrism1.z = (int)numericUpDown7.Value;
            rectPrism1.width = (int)numericUpDown8.Value;
            rectPrism1.height = (int)numericUpDown9.Value;
            rectPrism1.depth = (int)numericUpDown10.Value;



            if (sphere1.x + sphere1.radius >= rectPrism1.x && sphere1.x - sphere1.radius <= rectPrism1.x + rectPrism1.width && sphere1.y + sphere1.radius <= rectPrism1.y + rectPrism1.height && sphere1.z + sphere1.radius >= rectPrism1.z && sphere1.z - sphere1.radius <= rectPrism1.x + rectPrism1.depth)
            {
                MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 1;
            }
            else
            {
                MessageBox.Show("Collision has not occurred!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





        }
        class Sphere
        {
            public int x;
            public int y;
            public int z;
            public int radius;

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

        private void button2_Click(object sender, EventArgs e)
        {
            draw_sphere_rectprism d = new draw_sphere_rectprism();
            d.x = control;
            d.Show();
            this.Hide();
        }
    }
}
