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
    public partial class kure_kure : Form
    {
        public int control = 0;
        Sphere sphere1 = new Sphere();
        Sphere sphere2 = new Sphere();
        public kure_kure()

        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kure_kure k = new kure_kure();
            k.Show();
            this.Hide();
        }
        public void kureKure()
        {
            sphere1.x = (int)numericUpDown1.Value;
            sphere1.y = (int)numericUpDown2.Value;
            sphere1.z = (int)numericUpDown3.Value;
            sphere1.radius = (int)numericUpDown4.Value;
            sphere2.x = (int)numericUpDown5.Value;
            sphere2.y = (int)numericUpDown6.Value;
            sphere2.z = (int)numericUpDown7.Value;
            sphere2.radius = (int)numericUpDown8.Value;


            float distance = (float)Math.Sqrt(Math.Pow(sphere1.x - sphere2.x, 2) + Math.Pow(sphere1.y - sphere2.y, 2) + Math.Pow(sphere1.z - sphere2.z, 2));
            if (distance <= sphere1.radius + sphere2.radius)
            {

                MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 1;
            }
            else
            {
                MessageBox.Show("Collision has not occurred!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            kureKure();
            button2.Enabled = true;
        }
        class Sphere
        {
            public int x;
            public int y;
            public int z;
            public int radius;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_sphere_sphere s =new draw_sphere_sphere();
            s.x = control;
            s.Show();
            this.Hide();
        }
    }
}
