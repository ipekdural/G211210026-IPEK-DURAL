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
    public partial class kure_silindir : Form
    {
        public int control = 0;
        Sphere sphere1 = new Sphere();
        Cylinder cylinder1 = new Cylinder();
        public kure_silindir()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        public void kureSilindir()
        {
            sphere1.x = (int)numericUpDown1.Value;
            sphere1.y = (int)numericUpDown2.Value;
            sphere1.z = (int)numericUpDown3.Value;
            sphere1.radius = (int)numericUpDown4.Value;

            cylinder1.x = (int)numericUpDown5.Value;
            cylinder1.y = (int)numericUpDown6.Value;
            cylinder1.z = (int)numericUpDown7.Value;
            cylinder1.radius = (int)numericUpDown8.Value;
            cylinder1.height = (int)numericUpDown9.Value;

            float distance = (float)Math.Sqrt(Math.Pow(sphere1.x - cylinder1.x, 2) + Math.Pow(sphere1.y - cylinder1.y, 2) + Math.Pow(sphere1.z - cylinder1.z, 2));
            float toplamyaricap = sphere1.radius + cylinder1.radius;
            if (distance <= cylinder1.height / 2 && sphere1.radius <= cylinder1.radius || distance <= toplamyaricap)
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


        class Cylinder
        {
            public int x;
            public int y;
            public int z;
            public float radius;
            public float height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kureSilindir();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_sphere_cylinder d = new draw_sphere_cylinder();
            d.x = control;
            d.Show();
            this.Hide();

        }
    }
}
